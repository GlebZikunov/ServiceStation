using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zikunov.ServiceStation.Data.Constants;
using Zikunov.ServiceStation.Data.Models;

namespace Zikunov.ServiceStation.Data.Configurations
{
    /// <summary>
    /// EF Configuration for User entity.
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(Table.Users, Schema.User)
                .HasKey(user => user.Id);

            builder.Property(user => user.FullName)
                .IsRequired()
                .HasMaxLength(SqlConfiguration.SqlMaxLengthMedium);
        }
    }
}
