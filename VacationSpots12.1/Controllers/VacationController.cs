using VacationSpots12._1.Models;
using VacationSpots12._1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace VacationSpots12._1.Controllers
{
    public class VacationController : Controller
    {
        private IData _tempdata;
        //dependency injection

        public VacationController (IData tempdata)
        {

            _tempdata = tempdata;


        }
        [HttpGet]
        [Authorize(Roles = "Admin")] //prompt the user to login first
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Vacation obj)
        {
            if (ModelState.IsValid) //validation
            {
                _tempdata.AddVacation(obj);
                ViewBag.Message = "Vacation added successfully!";
            }
            return View(obj);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(int id)
        {
            Vacation obj = _tempdata.GetVacation(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Vacation obj, int id)
        {
            obj.Id = id;
            _tempdata.UpdateVacation(obj);
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            _tempdata.DeleteVacation(id);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Buyer")]
        public IActionResult Details(int? id)
        {
            var vac = _tempdata.GetVacation(id);

            if (vac == null)
            {

                return NotFound();

            }

            return View(vac);

        }



        [Authorize(Roles = "Buyer")]
        //sending the list of employees to the view 
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel(); //temp class 
            model.Vacations = _tempdata.ReadAll();
            return View(model);
        }
    }
}
