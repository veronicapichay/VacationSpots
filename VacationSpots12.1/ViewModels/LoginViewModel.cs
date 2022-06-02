using System.ComponentModel.DataAnnotations;



namespace VacationSpots12._1.ViewModels
{
    public class LoginViewModel
    {

        [Required (ErrorMessage = "Please enter user name")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter oassword")]
        [DataType (DataType.Password)]

        public string Password { get; set; }
        public bool RememberMe { get; set; }




    }
}
