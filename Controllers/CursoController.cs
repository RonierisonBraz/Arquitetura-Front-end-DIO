using Curso.WebApi.Models.Cursos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Curso.WebApi.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarCursoViewModelInput cadastrarCursoViewModelInput)
        {
            return View();
        }

        public IActionResult Listar()
        {

            var cursos = new List<ListarCursoViewOutput>
            {
                new ListarCursoViewOutput()
                {
                    Nome = "Curso A",
                    Descricao = "Descricao Curso A",
                    Login = "RonierisonBraz"
                },
                new ListarCursoViewOutput()
                {
                    Nome = "Curso B",
                    Descricao = "Descricao Curso B",
                    Login = "RonierisonBraz"
                }
            };

            return View(cursos);
        }

    }
}
