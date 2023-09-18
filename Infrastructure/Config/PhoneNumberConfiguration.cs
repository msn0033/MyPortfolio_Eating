using Core;
using Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.HasKey(x => x.Id);
            // builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.Property(x => x.n1)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(x => x.n2)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50)
               .IsRequired(false);

            builder.ToTable("PhoneNumbers");


            
        }
    }
}
