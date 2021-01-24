using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FKRM.Mvc.Controllers
{
    public class GenderController : Controller
    {
        private IGenderService _genderService;
        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] GenderViewModel genderViewModel)
        {
            _genderService.Register(genderViewModel);
            return Ok(genderViewModel);
        }
        public IActionResult Index()
        {
            return View(_genderService.GetAll());
        }
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genderViewModel = _genderService.GetById(id.Value);

            if (genderViewModel == null)
            {
                return NotFound();
            }
            return View(genderViewModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GenderViewModel genderViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(genderViewModel);
                _genderService.Register(genderViewModel);
                return View(genderViewModel);
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var genderViewModel = _genderService.GetById(id.Value);
            if (genderViewModel == null)
            {
                return NotFound();
            }
            return View(genderViewModel);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(GenderViewModel genderViewModel)
        {
            if (!ModelState.IsValid) return View(genderViewModel);

            _genderService.Update(genderViewModel);

            return View(genderViewModel);
        }
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var genderViewModel = _genderService.GetById(id.Value);
            if (genderViewModel == null)
            {
                return NotFound();
            }
            return View(genderViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _genderService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
