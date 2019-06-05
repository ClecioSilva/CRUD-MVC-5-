using RE.SistemaFaculdade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Application.ViewModels
{
    public class ALCACFPViewModel
    {
        public ALCACFPViewModel()
        {
            AlunoId = Guid.NewGuid();
            CustoAlunoId = Guid.NewGuid();
            CustofaculdadeId = Guid.NewGuid();            
            ProfissaoId = Guid.NewGuid();
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

        //[ScaffoldColumn(false)]
        //public DomainValidation.Validation.ValidationResult ValidationResult {get; set;}


        // CUSTOALUNO


        [Key]

        public Guid CustoAlunoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Transporte")]

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


        //CUSTOFACULDADE


        [Key]

        public  Guid CustofaculdadeId { get; set; }

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


        //PROFISSAO


        [Key]

        public Guid ProfissaoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Empresa")]

        public string Empresa { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Cargo")]

        public string Cargo { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Salario")]

        public string Salario { get; set; }

    }
}
