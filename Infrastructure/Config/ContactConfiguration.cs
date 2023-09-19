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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.ToTable("Contacts");

            //RelationShip
            // Contact ----- OWner
            builder.HasOne(x => x.Owner)
                 .WithOne(x => x.Contact)
                 .HasForeignKey<Contact>(x => x.OwnerId)
                 .IsRequired(true);
            builder.HasIndex(x => x.OwnerId).IsUnique();
            //
            // Contact ----- Address
            builder.HasMany(x => x.Address)
                .WithOne(x => x.Contact)
                .HasForeignKey(s => s.ContactId)
                .IsRequired(true);

            // Contact ----- Phone
            builder.HasOne(x => x.PhoneNumber)
                .WithOne(x => x.Contact)
                .HasForeignKey<Contact>(s => s.PhoneNumberId)
                .IsRequired(true);




        }
    }
}
