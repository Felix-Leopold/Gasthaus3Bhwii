using GasthausWebApp3Bhwii.Models;
using GasthausWebApp3Bhwii.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GasthausWebApp3Bhwii.Controllers;

public class ProduktController : Controller
{
    // GET
    public IActionResult Index()
    {
        ProduktRepository repo_produkt = new ProduktRepository();
        List<Produkt> myProdukte = repo_produkt.GetAllProdukts();
        
        
        return View(myProdukte);
       
    }
}