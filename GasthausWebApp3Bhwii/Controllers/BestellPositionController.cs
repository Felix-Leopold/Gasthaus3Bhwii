using GasthausWebApp3Bhwii.Models;
using GasthausWebApp3Bhwii.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GasthausWebApp3Bhwii.Controllers;

public class BestellPositionController : Controller
{
    // GET
    public IActionResult Index()
    {
        BestellungPositionRepository repo_bestellposition = new BestellungPositionRepository();
        List<BestellPosition> mybestellposition = repo_bestellposition.GetAllBestellPositionen();
        
        
        return View(mybestellposition);
    }
}