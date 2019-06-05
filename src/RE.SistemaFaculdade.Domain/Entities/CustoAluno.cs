using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Domain.Entities
{
    public class CustoAluno
    {
        public CustoAluno()
        {
            CustoAlunoId = Guid.NewGuid();
        }

        public Guid CustoAlunoId { get; set; }
        public int Transporte { get; set; }
        public int Alimentacao { get; set; }
        public int Aluguel { get; set; }
        public int Agua { get; set; }
        public int Luz { get; set; }
        public int Gaz { get; set; }
        public int Internet { get; set; }
        public int Roupa { get; set; }

        public Guid AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}
