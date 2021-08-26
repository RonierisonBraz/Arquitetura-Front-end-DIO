using System.ComponentModel.DataAnnotations;

namespace Curso.WebApi.Models.Cursos
{
    public class CadastrarCursoViewModelInput
    {

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do curso é obrigatório")]
        public string Descricao { get; set; }
    }
}
