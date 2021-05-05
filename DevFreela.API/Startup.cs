using DevFreela.Application.Commands.CreateComment;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Commands.CreateUser;
using DevFreela.Application.Commands.DeleteProject;
using DevFreela.Application.Commands.FinishProject;
using DevFreela.Application.Commands.StartProject;
using DevFreela.Application.Commands.UpdateProject;
using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Application.Queries.GetAllSkills;
using DevFreela.Application.Queries.GetProjectById;
using DevFreela.Application.Queries.GetUser;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using DevFreela.Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace DevFreela.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DevFreelaDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("DevFreelaCs")));

            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddMediatR(typeof(CreateProjectCommand)); //vai buscar todos os IResquestHandler que estão sendo implementados e irá associar os commands respectivos a eles
            services.AddMediatR(typeof(CreateCommentCommand));
            services.AddMediatR(typeof(DeleteProjectCommand));
            services.AddMediatR(typeof(UpdateProjectCommand));
            services.AddMediatR(typeof(CreateUserCommand));
            services.AddMediatR(typeof(FinishProjectCommand));
            services.AddMediatR(typeof(StartProjectCommand));

            services.AddMediatR(typeof(GetAllSkillsQuery));
            services.AddMediatR(typeof(GetAllProjectsQuery));
            services.AddMediatR(typeof(GetUserQuery));
            services.AddMediatR(typeof(GetProjectByIdQuery));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DevFreela.API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DevFreela.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
