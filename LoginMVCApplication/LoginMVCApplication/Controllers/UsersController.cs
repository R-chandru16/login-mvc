using LoginMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVCApplication.Controllers
{
    public class UsersController : Controller
    {
        private readonly LoginContext _context;
public UsersController(LoginContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return
          View();
        }
        [ HttpPost]
        public IActionResult Index(Users user)
        {
            ViewBag.Message = null;
            if (string.IsNullOrEmpty(user.EmailID)
            ||
            string.IsNullOrWhiteSpace(user.EmailID))
            {
                ViewBag.Message
              = "Enter Valid Email";
                return View();
            }
            else if (
          string.IsNullOrEmpty(user.Password)||
          string.IsNullOrWhiteSpace(user.Password))
            {
                ViewBag.Message = "Enter Valid password";
                return View();
            }
            else
            {
                if (_context.Users.Where(e => e.EmailID == user.EmailID
               &&
               e.Password
               ==
               user.Password).Any())
                {
                    TempData["Mail"] =
                  user.EmailID;
                    return RedirectToAction("Welcome");
                }
                else
                {
                    ViewBag.Message = "Invalid Email or Password";
                    return View();
                }
            }
           
        }
      
    public IActionResult Welcome(string Email)
        {
            return View();
        }
    }
}


       