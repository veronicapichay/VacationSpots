using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VacationSpots12._1.Models;
using VacationSpots12._1.ViewModels;

namespace VacationSpots12._1.Controllers
{
    public class AccountController : Controller
    {

        private SignInManager<User> signInManager;

        private UserManager<User> userManager;

        private RoleManager<IdentityRole> roleManager;


        public AccountController(SignInManager<User> _signin, UserManager<User> _user, RoleManager<IdentityRole> _role)
        {
            signInManager = _signin;
            userManager = _user;
            roleManager = _role;
        }



        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {

                return RedirectToAction("Index", "Vacation");

            }

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {

            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, false);

                //checks if sign in is successful
                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Employee");

                }

            }

            ModelState.AddModelError("", "Please try again!");
            return View();
        }


        public IActionResult Register()
        {


            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {

            if (ModelState.IsValid)
            {
                VacationSpots12._1.Models.User newuser = new User()
                {

                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    UserName = registerViewModel.UserName,
                    PhoneNumber = registerViewModel.PhoneNumber.ToString(),
                    Email = registerViewModel.Email

                };



                var result = await userManager.CreateAsync(newuser, registerViewModel.Password);

                //checks if sign in is successful
                if (result.Succeeded)
                {
                    var addedUser = await userManager.FindByNameAsync(newuser.UserName);
                    return RedirectToAction("Login", "Account");

                    if(addedUser.UserName == "Admin")
                    {

                        await userManager.AddToRoleAsync(addedUser, "Admin");




                    }

                    else
                    {

                        await userManager.AddToRoleAsync(addedUser, "Buyer");


                    }







                }

                foreach (var error in result.Errors)
                {

                    ModelState.AddModelError("", error.Description);

                }
            }
            return View();

        }

            public async Task<IActionResult> LogOut()
        {


            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }







        public IActionResult Index()
        {
            return View();
        }
    }
}
