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
    public class PortFolioItemConfiguration : IEntityTypeConfiguration<PortFolioItem>
    {
        public void Configure(EntityTypeBuilder<PortFolioItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.Property(x => x.ProjectName)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(x => x.ImageUrl)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(x => x.Description)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(100)
               .IsRequired(false);

            builder.ToTable("PortFolioItems");


            
        }
    }
}
