using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCGrid.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCGrid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var vModel = new List<Invoice>()
            {
                new Invoice()
                {
                    Id = "1",
                    //DateCreated = DateTime.Now,
                    InvoiceNumber = "123",
                    //LineItems = new List<Invoice.LineItem>()
                    //{
                    //    new Invoice.LineItem()
                    //    {
                    //        Id = 1,
                    //         Description = "1212",
                    //         Name = "Pra",
                    //         Price = 123,
                    //         Quantity = 12,
                    //         Total = 123
                    //    }
                    //},
                    //Total = 123
                },
                //new Invoice()
                //{
                //    Id = 1,
                //    DateCreated = DateTime.Now,
                //    InvoiceNumber = 1233,
                //    LineItems = new List<Invoice.LineItem>()
                //    {
                //        new Invoice.LineItem()
                //        {
                //            Id = 1,
                //             Description = "1212",
                //             Name = "Pra",
                //             Price = 123,
                //             Quantity = 12,
                //             Total = 123
                //        }
                //    },
                //    Total = 123
                //},
                //new Invoice()
                //{
                //    Id = 1,
                //    DateCreated = DateTime.Now,
                //    InvoiceNumber = 1233,
                //    LineItems = new List<Invoice.LineItem>()
                //    {
                //        new Invoice.LineItem()
                //        {
                //            Id = 1,
                //             Description = "1212",
                //             Name = "Pra",
                //             Price = 123,
                //             Quantity = 12,
                //             Total = 123
                //        }
                //    },
                //    Total = 123
                //}
            };
            return View(vModel[0]);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //public IActionResult Create(IList<MaterialViewModel> data)
        //{
        //    //var something = JsonConvert.DeserializeObject<List<Invoice>>(jsonObj);
        //    return View();
        //}

        public ActionResult Create(List<MaterialViewModel> rawmaterial)
        {
            
            //if (data != null)
            //{
            //    return Json("Success");
            //}
            //else
            //{
            //    return Json("An Error Has occoured");
            //}

            return Json("");

        }


    }
}
