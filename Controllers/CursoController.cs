using Curso.WebApi.Models.Cursos;
using Microsoft.AspNetCore.Mvc;

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

    }
}
