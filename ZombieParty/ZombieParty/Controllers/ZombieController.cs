using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;

namespace ZombieParty.Controllers
{
    public class ZombieController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.ZListe = new List<Zombie>()
    {
        new Zombie(){Name="Isbushk", Point=5, Type="Fiction"},
        new Zombie(){Name="Lenore", Point=4, Type="Fiction"},
        new Zombie(){Name="Draugr", Point=2, Type="Légendaire"},
        new Zombie(){Name="Revenant", Point=5, Type="Légendaire"},
        new Zombie(){Name="Tsuidecou", Point=1, Type="Légendaire"},
        new Zombie(){Name="Chien de l'enfer", Point=7, Type="Fiction"},
        new Zombie(){Name="Avogadro", Point=9, Type="Fiction"},
    };

            return View();
        }
    }
}
