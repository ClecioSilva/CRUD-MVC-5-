using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RE.SistemaFaculdade.Application.ViewModels
{
    public class AlunoViewModel
    {
        public AlunoViewModel()
        {
            AlunoId = Guid.NewGuid();
            CustoAlunos = new List<CustoAlunoViewModel>();
            CustoFaculdades = new List<CustoFaculdadeViewModel>();
            Profissaos = new List<ProfissaoViewModel>();
            

        }

        [Key]

        public Guid AlunoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MaxLength(11, ErrorMessage = "Maximo {0} caracteres")]
        [DisplayName("Telefone")]

        public string Tel { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email válido")]
        [DisplayName("E-mail")]

        public string Email { get; set; }

        [ScaffoldColumn(false)]

        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]

        public bool Ativo { get; set; }

        public ICollection<CustoAlunoViewModel> CustoAlunos { get; set; }
        public ICollection<CustoFaculdadeViewModel> CustoFaculdades { get; set; }
        public ICollection<ProfissaoViewModel> Profissaos { get; set; }
    }    
}
