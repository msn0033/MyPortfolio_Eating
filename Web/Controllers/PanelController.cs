﻿using Core.Entites;
using Core.InterFace;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class PanelController : Controller
    {
        private readonly IUnitOfWork<PortFolioItem> _portfolioitem;

        public PanelController(IUnitOfWork<PortFolioItem> portfolioitem)
        {
            this._portfolioitem = portfolioitem;
        }
        // GET: PanelController
        public ActionResult Index()
        {
            var portfolioitem=_portfolioitem.Entity.GetAll().Select(x=>new PortFolioItemVM
            {
                ImageUrl = x.ImageUrl,
                Description = x.Description,
                ProjectName = x.ProjectName,
                Id = x.Id,
                OwnerId = x.OwnerId,
                
            });
            return View(portfolioitem);
        }

        // GET: PanelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PanelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PanelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PanelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PanelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PanelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PanelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
