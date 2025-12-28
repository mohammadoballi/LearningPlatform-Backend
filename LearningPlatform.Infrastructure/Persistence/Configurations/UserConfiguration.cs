using LearningPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningPlatform.Infrastructure.Persistence.Configurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.IsActive)
               .IsRequired();

        builder.OwnsOne(u => u.Email, email =>
        {
            email.Property(e => e.Value)
                 .HasColumnName("Email")
                 .IsRequired();
        });

        builder.OwnsOne(u => u.FullName, name =>
        {
            name.Property(n => n.Value)
                .HasColumnName("FullName")
                .IsRequired();
        });

        builder.OwnsOne(u => u.Phone, phone =>
        {
            phone.Property(p => p.Value)
                 .HasColumnName("Phone")
                 .IsRequired();
        });
    }
}
