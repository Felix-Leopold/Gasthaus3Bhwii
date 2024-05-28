using GasthausWebApp3Bhwii.Models;
using GasthausWebApp3Bhwii.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GasthausWebApp3Bhwii.Controllers;

public class GastController : Controller
{
    // GET
    public IActionResult Index()
    {
        GastRepository repo_gast = new GastRepository();
        List<Gast> myGast = repo_gast.GetAllGaeste();
        
        
        return View(myGast);
    }
}