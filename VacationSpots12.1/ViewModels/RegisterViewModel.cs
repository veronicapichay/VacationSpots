


using System.ComponentModel.DataAnnotations;


namespace VacationSpots12._1.ViewModels
{
    public class RegisterViewModel : LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please add email")]
        public string Email { get; set; }


        public int PhoneNumber { get; set; }    



    }
}
