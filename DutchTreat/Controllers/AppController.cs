using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IDutchRepository _repository;

        public AppController(IMailService mailservice, IDutchRepository repository)
        {
            this._mailservice = mailservice;
            this._repository = repository;
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

        [Authorize]
        public IActionResult Shop()
        {
            //var results = _context.Products
            //    .OrderBy(p => p.Category)
            //    .ToList();

            //var results = from p in _context.Products
            //              orderby p.Category
            //              select p;

            // var results = _repository.GetAllProducts();

            //return View(results.ToList());

            return View();
        }
    }
}
