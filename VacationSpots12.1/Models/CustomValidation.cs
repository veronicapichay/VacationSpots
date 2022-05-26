using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;



namespace VacationSpots12._1.Models
{
    public class AllLetters : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            return ((string)value).All(Char.IsLetter);
        }





    }
}
