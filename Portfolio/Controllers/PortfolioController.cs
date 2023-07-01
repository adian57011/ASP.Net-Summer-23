using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
       public ActionResult Home()
        {
            
            return View();
        }

        public ActionResult MyProfile()
        {
            var profile = new Profile()
            {
                Name = "Muhaiminul Ashrafee",
                Age = "24",
                Email = "adian57011@gmail.com",
                Contact = "01969408414",
                Address = "Khilgaon,Dhaka-1219",
                Dob = "11 Nov 1999"
            };

            return View(profile);
        }

        public ActionResult MyCertification()
        {
            Certification BSC = new Certification()
            {
                Degree = "Bsc",
                Institute = "American International University-Bangladesh",
                Cgpa = "3.76",
                Year = "2017"
            };

            Certification HSC = new Certification()
            {

                Degree = "HSC",
                Institute = "Dhaka City College",
                Cgpa = "4.08",
                Year = "2017"
            };

            Certification SSC = new Certification()
            {

                Degree = "SSC",
                Institute = "Faizur Rahman Ideal Institute",
                Cgpa = "5.00",
                Year = "2017"

            };

            Certification[] myCertification = new Certification[] { BSC, HSC, SSC };
            ViewBag.Edus = myCertification;

            return View();
        }
    }
}