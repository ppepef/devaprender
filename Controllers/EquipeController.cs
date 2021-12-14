﻿using e_jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_jogos.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult representa retorno de status HTTP.
        Equipe equipeModel = new Equipe();

        //500 erro
        //200 OK

        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }


        public IActionResult Cadastrar(IFormCollection form)
        {
            //criar um objeto equipe a partir do frontend (IFormCollection)
            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(form["IdEquipe"]);
            nova_equipe.Nome = form["Nome"];
            nova_equipe.Imagem = form["Imagem"];

            //chamando a funcao create do objeto passando a nova equipe.
            equipeModel.Create(nova_equipe);

            ViewBag.Equipes = equipeModel.ReadAll();

            return LocalRedirect("~/Equipe");

        }
    }
}
