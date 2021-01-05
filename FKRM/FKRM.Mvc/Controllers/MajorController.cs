using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Controllers
{
    public class MajorController : Controller
    {
        private IMajorService _majorService;
        public MajorController(IMajorService majorService)
        {
            _majorService = majorService;
        }
        public ActionResult Index()
        {
            return View(_majorService.GetMajors());
        }

        // GET: MajorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MajorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MajorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] MajorViewModel majorViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _majorService.Create(majorViewModel);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(majorViewModel);
        }

        // GET: MajorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MajorController/Edit/5
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

        // GET: MajorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MajorController/Delete/5
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
