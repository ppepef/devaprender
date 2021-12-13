using e_jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_jogos.Controllers
{
    public class EquipeController : Controller
    {

        Equipe equipeModel = new Equipe();


        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }


        public IActionResult Cadastrar(IFormCollection form)
        {

        }
    }
}
