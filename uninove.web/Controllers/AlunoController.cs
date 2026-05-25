using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using uninove.web.Models;

namespace uninove.web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index ()
    {
        ViewBag.Nome = "Amanda";
        ViewBag.Curso = "ADS";
        ViewBag.Semestre = "1ºSemestre";
        
        return View();

    }

    public IActionResult Detalhes (int id)
    {
        ViewBag.Alunoid = id;
        return View();
    

    }
}