using AquaVida.Models;
using Microsoft.AspNetCore.Mvc;

namespace AquaVida.Controllers;

public class InscripcionesController : Controller
{
    [HttpGet]
    public IActionResult Crear()
    {
        return View(new Inscripcion());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Crear(Inscripcion inscripcion)
    {
        if (!ModelState.IsValid)
        {
            return View(inscripcion);
        }

        // En esta versión académica los datos se validan y se muestran,
        // pero no se guardan de forma permanente en una base de datos.
        return View("Confirmacion", inscripcion);
    }
}
