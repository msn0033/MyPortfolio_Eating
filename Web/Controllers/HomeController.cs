using Core;
using Core.Entites;
using Core.InterFace;
using Infrastructure.Data;
using Infrastructure.Seeding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using System.Net.Mail;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PhoneNumber> _phonenumber;
        private readonly IUnitOfWork<Contact> _contact;
        private readonly IUnitOfWork<Address> _address;
        private readonly IUnitOfWork<PortFolioItem> _portfolioitem;
        private readonly Context _context;

        public HomeController(IUnitOfWork<Owner> owner, IUnitOfWork<PhoneNumber> phonenumber,
            IUnitOfWork<Contact> contact,
            IUnitOfWork<Address> address,
            IUnitOfWork<PortFolioItem> portfolioitem,
            Context context)
        {
            this._owner = owner;
            this._phonenumber = phonenumber;
            this._contact = contact;
            this._address = address;
            this._portfolioitem = portfolioitem;
            this._context = context;
        }
        public async Task<IActionResult> Index()
        {

            var ob = new Seed(_context);
             await ob.Seddingdata();

            var modelVm = _contact.Entity.GetAll().Select(x => new HomeVM
            {
                Owner = x.Owner,
                Address = x.Address,
                PhoneNumber = x.PhoneNumber,
                PortFolioItems = x.Owner!.PortFolioItem
            }).First();

            return View(modelVm);
        }


    }
}
