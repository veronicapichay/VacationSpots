using VacationSpots12._1.Models;
using VacationSpots12._1.Services;
using Microsoft.AspNetCore.Mvc;


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

        public IActionResult Create()
        {

            return View();
        }

        public IActionResult Details(int? id)
        {
            var vac = _tempdata.GetVacation(id);

            if (vac == null)
            {

                return NotFound();

            }

            return View(vac);

        }

        //sending the list of employees to the view 
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel(); //temp class 
            model.Vacations = _tempdata.ReadAll();
            return View(model);
        }
    }
}
