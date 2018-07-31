using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailservice;

        public AppController(IMailService mailservice)
        {
            this._mailservice = mailservice;
        }

        public IActionResult Index()
        {
            // throw new InvalidOperationException("xxxtttttxxxx");
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // send the email
                _mailservice.SendMessage(
                    "David.Osborne@CallaghanInnovation.govt.nz", 
                    model.Subject, 
                    $"From: {model.Name} - {model.Email}, Message: {model.Message}"
                );

                ViewBag.UserMessage = "Mail Sent";

                ModelState.Clear();
            }
            else
            {
                // show errors
            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
