using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class PokemonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pokemon()
        {
            ViewBag.Message = "Pokemons";

            return View();
        }

        public ActionResult Treinadores()
        {
            ViewBag.Message = "Treinadores";

            return View();
        }
    }
}