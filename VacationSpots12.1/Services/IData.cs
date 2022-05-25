using System.Collections.Generic;
using VacationSpots12._1.Models;

namespace VacationSpots12._1.Services
{
    public interface IData
    {

        List <Vacation> Vacations { get; set; }
        List<Vacation> ReadAll();
        Vacation GetVacation(int? id);


        //CRUD
        void AddVacation(Vacation vacation);
        void UpdateVacation(Vacation vacation);
        void DeleteVacation(int? id);





    }
}
