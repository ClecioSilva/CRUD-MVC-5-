using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Application.ViewModels
{
    public class ProfissaoViewModel
    {
        public ProfissaoViewModel()
        {
            ProfissaoId = Guid.NewGuid();
        }

        [Key]

        public Guid ProfissaoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Empresa")]

        public string Empresa { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Cargo")]

        public string Cargo { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Salario")]

        public string Salario { get; set; }

       
        [ScaffoldColumn(false)]

        public Guid AlunoId { get; set; }
    }
}