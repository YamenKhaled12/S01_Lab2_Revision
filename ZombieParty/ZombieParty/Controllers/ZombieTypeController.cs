using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;

public class ZombieTypeController : Controller
{
    public IActionResult Index()
    {
        this.ViewBag.MaListe = new List<ZombieType>()
        {
            new ZombieType(){TypeName="Virus", Id=1},
            new ZombieType(){TypeName="Contact", Id=2}
        };

        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ZombieType zombieType)
    {
        if (ModelState.IsValid)
        {
            
        }

        return View(zombieType);
    }
}