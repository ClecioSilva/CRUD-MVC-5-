using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Domain.Entities
{
    public class Profissao
    {
       public Profissao()
        {
            ProfissaoId = Guid.NewGuid();
        }

        public Guid ProfissaoId { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }

        public Guid AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}
