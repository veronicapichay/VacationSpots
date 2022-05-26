using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VacationSpots12._1.Models
{
    public class Categories
    {
        [Key] //primary in the table 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //1 to many relation 
        public virtual ICollection <Vacation> Vacations { get; set; }






    }
}
