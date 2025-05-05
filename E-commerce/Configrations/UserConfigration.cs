using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Configrations
{
    public class UserConfigration
    {
        public class UserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.HasKey(u => u.UserID);

                builder.Property(u => u.Username)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

               

                builder.Property(u => u.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                builder.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(u => u.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(u => u.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(u => u.Role)
                    .IsRequired()
                    .HasConversion<string>();

                builder.Property(u => u.IsActive)
                    .HasDefaultValue(true);

                builder.Property(u => u.DateCreated)
                    .HasDefaultValueSql("GETDATE()");

            }
        }
    }
}
