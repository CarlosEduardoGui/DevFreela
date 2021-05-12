using Microsoft.EntityFrameworkCore.Migrations;

namespace DevFreela.Infrastructure.Migrations
{
    public partial class Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Projects_IdProject",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_IdUser",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "ProjectComments");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_IdUser",
                table: "ProjectComments",
                newName: "IX_ProjectComments_IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_IdProject",
                table: "ProjectComments",
                newName: "IX_ProjectComments_IdProject");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectComments",
                table: "ProjectComments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectComments_Projects_IdProject",
                table: "ProjectComments",
                column: "IdProject",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectComments_Users_IdUser",
                table: "ProjectComments",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectComments_Projects_IdProject",
                table: "ProjectComments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectComments_Users_IdUser",
                table: "ProjectComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectComments",
                table: "ProjectComments");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "ProjectComments",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectComments_IdUser",
                table: "Comments",
                newName: "IX_Comments_IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectComments_IdProject",
                table: "Comments",
                newName: "IX_Comments_IdProject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Projects_IdProject",
                table: "Comments",
                column: "IdProject",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_IdUser",
                table: "Comments",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
