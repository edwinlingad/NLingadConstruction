using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLLingadConstruction.Models;

namespace NLLingadConstruction.Controllers
{
    public class HomeController : Controller
    {
        List<ProjectViewModel> projects = new List<ProjectViewModel> {
            new ProjectViewModel {
                ImageUrl = "/Content/Images/NLLingad.jpg",
                Owner = "Arch. and Mrs. Nelson L. Lingad",
                Location = "Woodbridge Village, Lakeshore, Mexico, Pampanga"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/MarvinNaguit.jpg",
                Owner = "Mr. and Mrs. Marvin Naguit",
                Location = "St. Jude Village, City of San Fernando, Pampanga"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/RicoMalonzo.jpg",
                Owner = "Mr. and Mrs. Rico Malonzo",
                Location = "Marquee Place, Angeles City"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/TeofiloLeonardo.jpg",
                Owner = "Mr. Teofilo Leonardo",
                Location = "Waterwood Village, Baliuag, Bulacan"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/WilliamPingul.jpg",
                Owner = "Mr. William Pingul",
                Location = "Juliana Subd., City of San Fernando, Pampanga"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/RodolfoSantos.jpg",
                Owner = "Mr. Rodolfo Santos",
                Location = "Lazatin Blvd., City of San Fernando, Pampanga"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/TeofiloLeonardo2.jpg",
                Owner = "Mr. Teofilo Leonardo",
                Location = "Angat, Bulacan"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/BenjieSantos.jpg",
                Owner = "Col. and Mrs. Benjie Santos",
                Location = "Loyola Grand Villas, Quezon City"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/JonCoronel.jpg",
                Owner = "Mr. and Mrs. Jon Coronel",
                Location = "Mandaluyong City"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/DennisLumpay.jpg",
                Owner = "Engr. and Mrs. Dennis Lumpay",
                Location = "Marquee Place, Angeles City, Pampanga"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/ReyBatomalaque.jpg",
                Owner = "Engr. and Mrs. Rey Batomalaque",
                Location = "Cross Creek Subdivision, Lakeshore, Mexico, Pampanga"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/ArmindaRivera.jpg",
                Owner = "Ms. Arminda Rivera",
                Location = "Greenfields Executive Homes, Sindalan, City of San Fernando, Pampanga"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/MyrnaOcampo.jpg",
                Owner = "Mrs. Myrna Ocampo",
                Location = "Sta. Teresita, City of San Fernando, Pampanga"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/MilagrosOng.jpg",
                Owner = "Mrs. Milagros Ong",
                Location = "United Hills Subd., Paranaque City"
            },
            new ProjectViewModel {
                ImageUrl = "/Content/Images/ReligayaRivera.jpg",
                Owner = "Dra. Religaya Rivera",
                Location = "Dizon Estate, City of San Fernando, Pampanga"
            }
        };

        public ActionResult Index()
        {
            return View(projects);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}