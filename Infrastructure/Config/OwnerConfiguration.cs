﻿using Core.Entites;
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
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasValueGenerator<SequentialGuidValueGenerator>();
            builder.ToTable("Owners");


            //RelationShip
            builder.HasMany(x => x.Address)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId)
                .IsRequired(false);
        }
    }
}