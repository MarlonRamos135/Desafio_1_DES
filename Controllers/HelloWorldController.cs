using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace MVCPeliculas.Controllers;

public class HelloWorldController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    public ActionResult Welcome(string nombre, int numVeces = 1)
    {
        ViewData["nombre"] = "Hola " + nombre;
        ViewData["numVeces"] = numVeces;
        return View();
    }
    public string Greeting(string nombre, int id = 1)
    {
        return HtmlEncoder.Default.Encode($"Hola{nombre}, ID: {id}");
    }
}

