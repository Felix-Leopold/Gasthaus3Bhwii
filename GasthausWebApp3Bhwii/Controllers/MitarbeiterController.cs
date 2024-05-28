using GasthausWebApp3Bhwii.Models;
using GasthausWebApp3Bhwii.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GasthausWebApp3Bhwii.Controllers;

public class MitarbeiterController : Controller
{
    // GET
    public IActionResult Index()
    {
        MitarbeiterRepository repo_mitarbeiter = new MitarbeiterRepository();
        List<Mitarbeiter> myMitarbeiter = repo_mitarbeiter.GetAllMitarbeiter();
        
        
        return View(myMitarbeiter);
    }
}