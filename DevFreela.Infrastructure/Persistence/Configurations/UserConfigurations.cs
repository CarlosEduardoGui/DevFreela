using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
    .HasKey(x => x.Id);

            builder
                .HasMany(x => x.Skills)
                .WithOne(s => s.User)
                .HasForeignKey(x => x.IdSkill)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
