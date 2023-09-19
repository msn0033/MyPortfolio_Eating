using Core.Entites;
using Infrastructure.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("newid()");

            builder.Property(x => x.FName)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50)
               .IsRequired();
            builder.Property(x => x.LName)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50)
               .IsRequired();
            builder.Property(x => x.Avatar)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50)
               .IsRequired();
            builder.Property(x => x.Profil)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50)
               .IsRequired();


            builder.ToTable("Owners");

            // Owner ----- PortFolioItem
            builder.HasMany(x => x.PortFolioItem)
                   .WithOne(x => x.Owner)
                   .HasForeignKey(x => x.OwnerId)
                   .IsRequired(true);

         // builder.HasData(Seed.LoadOwner());
        //  builder.HasData(Seed.LoadAddress());

        }
    }
}
