using Core;
using Core.Entites;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Seeding
{
    public class Seed
    {
        public readonly Context _contex;
        public Seed(Context contex)
        {
            this._contex = contex;
        }
   
        public async Task  Seddingdata()
        {
            var owner1 = new Owner { FName = "saeed", LName = "saleh", Avatar = "mur.jpg", Profil = " i have plan" };
            var phone1 = new PhoneNumber { n1 = "33333333", n2 = "44444444" };
            var contact1 = new Contact { OwnerId = owner1.Id, PhoneNumberId = phone1.Id };
            var address1 = new Address { Street = "road 70", City = "dammmam", MainAddress = true, ContactId = contact1.Id };
            var port1 = new PortFolioItem { ProjectName = "Instagram", Description = "Instagram is good", ImageUrl = "instagram.png", OwnerId = owner1.Id };
            var s = await _contex.Database.EnsureCreatedAsync();

            if (!s)
            {
                if(!_contex.Owners.Any())
                {
                    using (var transaction = _contex.Database.BeginTransaction())
                    {
                        try
                        {
                            await _contex.Owners.AddAsync(owner1);
                            await _contex.PhoneNumbers.AddAsync(phone1);
                            await _contex.Contacts.AddAsync(contact1);
                            await _contex.Addresss.AddAsync(address1);
                            await _contex.PortFolioItems.AddAsync(port1);

                            await _contex.SaveChangesAsync();

                            await transaction.CommitAsync();
                            Console.WriteLine("goood");
                        }
                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("errorororororororor");
                            // throw;
                        }
                    }//end transation
                }
            }
        


        }//end funtion
    }
}
