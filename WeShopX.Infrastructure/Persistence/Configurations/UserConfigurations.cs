using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeShopX.Domain.UserManagement;
using WeShopX.Domain.UserManagement.Entities;
using WeShopX.Domain.UserManagement.ValueObjects;

namespace WeShopX.Infrastructure.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USERS");
            builder.HasKey(x => x.Id);

            builder.Property(u => u.Id)
                .HasConversion(
                    id => id.Value,
                    val => UserId.Create());

            builder.Property(u => u.Firstname)
                .HasMaxLength(100);

            builder.Property(u => u.Lastname)
                .HasMaxLength(100);

            builder.OwnsOne(u => u.Email, email =>
            {
                email.Property(e => e.Value)
                    .HasColumnName("Email");
            });

            builder.OwnsOne(u => u.MobileNo, mobile =>
            {
                mobile.Property(m => m.CountryCode)
                   .HasColumnName("MobileNo_CountryCode") // Default naming conventions for value objects
                   .HasMaxLength(5);

                   mobile.Property(m => m.Number)
                    .HasColumnName("Number")
                    .HasMaxLength(11);
            });

            builder.Property(u => u.Weight)
            .HasPrecision(18, 2);
            builder.Property(u => u.Height)
            .HasPrecision(18, 2);

            //Use OwnsOne if ShoppingCart is a value object(part of the User entity, does not have its own identity, and is not referenced independently).
            //Use HasOne if ShoppingCart is an entity (has its own identity and may be referenced separately).

            //builder.HasOne(u => u.Cart, cartBuilder =>
            //{
            //    cartBuilder.
            //});

            builder.HasOne(u => u.Cart)
                .WithOne()
                .HasForeignKey<ShoppingCart>(c => c.UserId);



        }
    }
}
