using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4_Zilbersztein_Entenza.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Ejemplo()
    {
        //dejamos este viewbag cómo ejemplo, podría ir el texto directo en la vista
        ViewBag.Titulo = "Listado de Destinos";
        ViewBag.Destinos = ORTWorld.ListaDestinos;
        return View();
    }

    public IActionResult Index()
    {
        ViewBag.PaquetesIndex = ORTWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete()
    {
        ViewBag.ListaDestinosIndex = ORTWorld.ListaDestinos;
        ViewBag.ListaAereosIndex = ORTWorld.ListaAereos;
        ViewBag.ListaHotelesIndex = ORTWorld.ListaHoteles;
        ViewBag.ListaExcursionesIndex = ORTWorld.ListaExcursiones;
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        Paquete paquete = (ORTWorld.ListaHoteles[Hotel-1], ORTWorld.ListaAereos[Aereo-1], ORTWorld.ListaExcursiones[Excursion-1]);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
