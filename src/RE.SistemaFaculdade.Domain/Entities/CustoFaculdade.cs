using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Domain.Entities
{
    public class CustoFaculdade
    {
        public CustoFaculdade()
        {
            CustoFaculdadeId = Guid.NewGuid();
        }

        public Guid CustoFaculdadeId { get; set; }
        public string NomeFacul { get; set; }
        public string Instituicao { get; set; }
        public string Curso { get; set; }
        public int Bolca { get; set; }
        public int ValorFaculdade { get; set; }
        public int MaterialAuxilio { get; set; }

        public Guid AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

       
    }
}
