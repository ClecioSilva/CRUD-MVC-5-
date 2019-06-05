using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Domain.Entities
{
    public class Aluno
    {
        public Aluno()
        {
            AlunoId = Guid.NewGuid();
            CustoAlunos = new List<CustoAluno>();
            CustoFaculdades = new List<CustoFaculdade>();
            Profissaos = new List<Profissao>();
        }

        public Guid AlunoId { get; set; }

        public string Nome { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }
        
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual ICollection<CustoAluno> CustoAlunos { get; set; }
        public virtual ICollection<CustoFaculdade> CustoFaculdades { get; set; }
        public virtual ICollection<Profissao> Profissaos { get; set; }
        public object CustoFaculdade { get; set; }

        public static Aluno FirstOrDefault()
        {
            throw new NotImplementedException();
        }
    }
}
