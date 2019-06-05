using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Application.ViewModels
{
    public class CustoFaculdadeViewModel
    {
        public CustoFaculdadeViewModel()
        {
            CustofaculdadeId = Guid.NewGuid();
        }

        [Key]

        public Guid CustofaculdadeId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Nome Faculdade")]

        public string NomeFacul { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Instituição")]

        public string Instituicao { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Curso")]

        public string Curso { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Bolça")]

        public string Bolca { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Valor Faculdade")]

        public string ValorFaculdade { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Material Auxilio")]

        public string MaterialAuxilio { get; set; }       

        [ScaffoldColumn(false)]

        public Guid AlunoId { get; set; }
    }
}
   