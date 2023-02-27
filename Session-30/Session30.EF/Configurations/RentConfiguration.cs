using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.EF.Configurations
{
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            // Table Name
            builder.ToTable("Rent");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Price).HasMaxLength(50).IsRequired();
           

            // Relations

        }
    }
}
