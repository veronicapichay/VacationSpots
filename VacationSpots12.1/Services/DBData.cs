using System.Collections.Generic;
using VacationSpots12._1.Models;

namespace VacationSpots12._1.Services
{
    public class DBData : IData
    {
        public List<Vacation> Vacations { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        private VacationContext vacationContext;
        public DBData (VacationContext _vacationContext)
        {

            vacationContext = _vacationContext;



        }



        public void AddVacation(Vacation vacation)
        {
            
            if (vacation.Categories.ToString() == "Backpacking")
            {

                vacation.CategoryId = 1;

            }


            if (vacation.Categories.ToString() == "Outback")
            {

                vacation.CategoryId = 2;

            }


            if (vacation.Categories.ToString() == "City")
            {

                vacation.CategoryId = 3;

            }


            if (vacation.Categories.ToString() == "Island")
            {

                vacation.CategoryId = 4;

            }

            vacationContext.Vacations.Add(vacation);
            vacationContext.SaveChanges();

        }

        public void DeleteVacation(int? id)
        {


            var vac = vacationContext.Vacations.Find(id);

            if (vac != null)
            {

                vacationContext.Vacations.Remove(vac);
                vacationContext.SaveChanges();

            }

        }

        public Vacation GetVacation(int? id)
        {

            return vacationContext.Vacations.Find(id);


        }

        public List<Vacation> ReadAll()
        {

            return new List<Vacation>(vacationContext.Vacations);

        }

        public void UpdateVacation(Vacation vacation)
        {
            
            var vac = vacationContext.Vacations.Find(vacation.Id);

            if (vac != null)
            {
                vac.Id = vacation.Id;
                vac.Name = vacation.Name;
                vac.Days = vacation.Days;
                vac.Description = vacation.Description;
                vac.ImageName = vacation.ImageName;
                vac.Categories = vacation.Categories;
                vac.Price = vacation.Price;

            }


            if (vacation.Categories.ToString() == "Backpacking")
            {

                vac.CategoryId = 1;

            }


            if (vacation.Categories.ToString() == "Outback")
            {

                vac.CategoryId = 2;

            }


            if (vacation.Categories.ToString() == "City")
            {

                vac.CategoryId = 3;

            }


            if (vacation.Categories.ToString() == "Island")
            {

                vac.CategoryId = 4;

            }

            vacationContext.SaveChanges();


        }
    }
}
