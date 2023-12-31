﻿using Core;
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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
           builder.Property(x => x.Id).HasDefaultValueSql("newid()");
          builder.Property(x=>x.Street)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50)
                .IsRequired();
          builder.Property(x => x.City)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.ToTable("Addresss");


            
        }
    }
}
