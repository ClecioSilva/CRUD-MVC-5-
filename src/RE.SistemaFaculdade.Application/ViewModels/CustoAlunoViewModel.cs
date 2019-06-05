using System;
using System.ComponentModel.DataAnnotations;

namespace RE.SistemaFaculdade.Application.ViewModels
{
    public class CustoAlunoViewModel
    {
        public CustoAlunoViewModel()
        {
            CustoAlunoId = Guid.NewGuid();
        }

        [Key]

        public Guid CustoAlunoId { get; set; }

        [Required(ErrorMessage ="Preencha o Campo Transporte")]
        
        public string Transporte { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Alimentação")]

        public string Alimentacao { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Aluguel")]

        public string Aluguel { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Agua")]

        public string Agua { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Luz")]

        public string Luz { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Gaz")]

        public string Gaz { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Internet")]

        public string Internet { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Roupa")]

        public string Roupa { get; set; }

        [ScaffoldColumn(false)]

        public Guid AlunoId { get; set; }        
    }
}
