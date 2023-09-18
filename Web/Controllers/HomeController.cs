using Core;
using Core.Entites;
using Core.InterFace;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericRepository<Owner> _repository;

        //private readonly Context context;

        //public HomeController(Context context)
        //{
        //    this.context = context;
        //}

        public HomeController(IGenericRepository<Owner> repository)
        {
            this._repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            //using (var con=context)
            //{

            //   if( await con.Database.EnsureCreatedAsync())
            //    {
            //        var owner1 = new Owner { FName = "saeed", LName = "saleh", Avatar = "sa.jpg", Profil = " i have plan" };
            //        var phone1 = new PhoneNumber { n1 = "33333333", n2 = "44444444" };
            //        var contact1=new Contact { OwnerId = owner1.Id ,PhoneNumberId= phone1.Id};
            //        var address1 = new Address { Street = "road 70", City = "dammmam", MainAddress = true, ContactId = contact1.Id };
                    


            //        using (var transaction = con.Database.BeginTransaction())
            //        {
            //            try
            //            {
            //                await context.Owners.AddAsync(owner1);
            //                await context.PhoneNumbers.AddAsync(phone1);
            //                await context.Contacts.AddAsync(contact1);
            //                await context.Addresss.AddAsync(address1);
            //                await context.SaveChangesAsync();

            //                await transaction.CommitAsync();
            //                Console.WriteLine("goood");
            //            }
            //            catch (Exception ex)
            //            {
            //                await transaction.RollbackAsync();
            //                Console.WriteLine(ex.Message);
            //                Console.WriteLine("errorororororororor");
            //                // throw;
            //            }
            //        }

                   
                    
                    
            //    }
            //    else
            //    {
            //        //var s = Guid.Parse("28B23ECB-93F1-41BA-8604-24DE892FBE1C");
            //        //var info=con.Contacts.Where(x=>x.OwnerId==s).Select(x => new
            //        //{
            //        //    x.Owner.FullName,
            //        //    ph1 = x.PhoneNumber.n1,
            //        //    ph2 = x.PhoneNumber.n2,
            //        //    address = x.Address.Select(x => new 
            //        //    {
            //        //       x.City,
            //        //       x.Street,
            //        //        Main=string.Join(" ",x.MainAddress?"main": " ")
            //        //    })
            //        //}).ToList() ;

            //        //foreach (var item in info)
            //        //{
            //        //    Console.Write($"{item.FullName} - {item.ph1} - {item.ph2} ");
            //        //    foreach (var it in item.address)
            //        //    {
            //        //        Console.WriteLine($"{it.City} - {it.Street} - {it.Main} ");
            //        //    }
            //        //}

            //        var owner = con.Owners.Select(x => new
            //        {
            //            fullname = x.FullName,
            //            x.Avatar,
            //            x.Profil,
            //            ph1=x.Contact!.PhoneNumber!.n1,
            //            ph2=x.Contact.PhoneNumber.n2,
            //            address = x.Contact.Address.Select(x => new {
            //            x.City,
            //            x.Street,
            //            main=string.Join(" ",x.MainAddress?"main":" second")

            //            })
            //        }).ToList();
            //        foreach (var item in owner)
            //        {
            //            Console.Write($"{item.fullname} - {item.ph1} - {item.ph2} - {item.Avatar} - {item.Profil} ");
            //            foreach (var it in item.address)
            //            {
            //                Console.WriteLine($"{it.City} - {it.Street} - {it.main} ");
            //            }
            //        }

            //    }
            //}
               
            return View();
        }
    }
}
