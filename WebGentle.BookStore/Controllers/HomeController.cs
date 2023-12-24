using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Helpers;
using WebGentle.BookStore.Model;
using WebGentle.BookStore.Service;

namespace WebGentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        public HomeController(IConfiguration configuration, IUserService userService, IEmailService emailService)
        {
            _configuration = configuration;
            _userService = userService;
            _emailService = emailService;
        }
        public async Task<ViewResult> Index()
        {
            //var userId = _userService.GetUserId();
            //var isLoggedIn = _userService.IsAuthenticated();

            //var newBook = new NewBookAlertConfig();
            //_configuration.Bind("NewBookAlert", newBook);
            //bool BookAlert = newBook.BookAlert;
            //string BookName = newBook.BookName;

            //var newBook = _configuration.GetSection("NewBookAlert");
            //var result = newBook.GetValue<bool>("BookAlert");
            //var result2 = newBook.GetValue<string>("BookName");
            //var result = _configuration.GetValue<bool>("NewBookAlert:BookAlert");
            //var result2 = _configuration.GetValue<string>("NewBookAlert:BookName");

            //var result3 = _configuration["AppName"];
            //var result4 = _configuration["infoObj:key1"];
            //var result5 = _configuration["infoObj:key2"];
            //var result6 = _configuration["infoObj:key3:key3Obj"];


            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
