using GasthausWebApp3Bhwii.Models;
using GasthausWebApp3Bhwii.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GasthausWebApp3Bhwii.Controllers;

public class BestellungController : Controller
{
    // GET
    public IActionResult Index()
    {
        BestellungRepository repo_bestellung = new BestellungRepository();
        List<Bestellung> mybestellung = repo_bestellung.GetAllBestellungen();
        
        
        return View(mybestellung);
    }
}