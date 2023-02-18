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
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            // Table Name
            builder.ToTable("Transaction Lines");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.TotalValue).HasPrecision(9, 2).IsRequired();
            builder.Property(t => t.NetValue).HasPrecision(9, 2).IsRequired();
            builder.Property(t => t.TotalValue).HasPrecision(9, 2).IsRequired();
            builder.Property(t => t.ItemPrice).HasPrecision(9, 2).IsRequired();
            builder.Property(t => t.DiscountPercent).HasPrecision(4, 2);
            builder.Property(t => t.DiscountValue).HasPrecision(9, 2);
            builder.Property(t => t.Quantity).HasMaxLength(20).IsRequired();


            // Relations
            builder.HasOne(t => t.Item)
                .WithMany(t => t.TransactionLines)
                .HasForeignKey(t => t.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Transaction)
                .WithMany(t => t.TransactionLines)
                .HasForeignKey(t => t.TransactionId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
