using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtletiASPMVC.Models;

namespace AtletiASPMVC.Controllers
{
    public class NationsController : Controller
    {
        // GET: Nations
        public ActionResult Random()
        {
            //Interrogazione del model

            using(OlympicsEntities model = new OlympicsEntities())
            {

                Random RandomGenerator = new Random();
                int RandomValue = RandomGenerator.Next(model.Nationalities.Count() - 1);

                Nationality nation = model.Nationalities
                    .OrderBy(o => o.Id)
                    .Skip(RandomValue)
                    .FirstOrDefault();

                return View(nation);
            }
        }
    }
}