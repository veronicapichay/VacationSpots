using Microsoft.AspNetCore.Identity;

namespace VacationSpots12._1.Models
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }



    }
}
