using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Data;
using FitnessTracker.Models;
using FitnessTracker.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace FitnessTracker.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        public AuthController(SignInManager<IdentityUser> _signInManager, UserManager<IdentityUser> _userManager, FitnessTrackerDBContext db)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(RegisterViewModel userData)
        {
            var newUser = new User()
            {
                UserName = userData.UserName,
                FirstName = userData.FirstName,
                LastName = userData.LastName,
                Age = userData.Age,
                Weight = userData.Weight,
                Height = userData.Height,
                EmailConfirmed = true,
                Gender = userData.Gender
            };
            var result = await userManager.CreateAsync(newUser, userData.Password);

            if (result.Succeeded) { 
                await signInManager.SignInAsync(newUser, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }
            else { 
                //return error
            }
            //todo add appropriate message for invalid data inputs
            return View("Register", userData);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> LoginAction(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            //ToDo add incorrect data validation error messages in view
            return View("Login", model);
            
        }
    }
}        
