using Core.Entites;
using Core.InterFace;

using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class PanelController : Controller
    {
        private readonly IUnitOfWork<PortFolioItem> _portfolioitem;
        private readonly IWebHostEnvironment _hosting;

        public PanelController(IUnitOfWork<PortFolioItem> portfolioitem, IWebHostEnvironment hosting)
        {
            this._portfolioitem = portfolioitem;

            this._hosting = hosting;
        }
        // GET: PanelController
        public ActionResult Index()
        {
            var portfolioitem = _portfolioitem.Entity.GetAll().Select(x => new PortFolioItemVM
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
            var idopject=_portfolioitem.Entity.GetAll().Select(x=>new  PortFolioItemVM
            {
              OwnerId=x.OwnerId
            }).FirstOrDefault();
            return View(idopject);
        }

        // POST: PanelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PortFolioItemVM portFolioItemVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (portFolioItemVM.Formfile != null)
                    {
                        string namefile = portFolioItemVM.Formfile.FileName;
                        string root = _hosting.WebRootPath + @"\img\portfolio\";
                        string pathFull = Path.Combine(root, namefile);
                        await portFolioItemVM.Formfile.CopyToAsync(new FileStream(pathFull, FileMode.Create));

                        var model = new PortFolioItem
                        {
                            ProjectName = portFolioItemVM.ProjectName,
                            Description = portFolioItemVM.Description,
                            ImageUrl = namefile,
                            OwnerId = portFolioItemVM.OwnerId,
                        };
                        await _portfolioitem.Entity.InsertAsync(model);
                        await _portfolioitem.SaveAsync();
                        return RedirectToAction(nameof(Index));
                    }
                  
                }

                catch
                {
                    return View(portFolioItemVM);
                }

            }

            return View(portFolioItemVM);
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
