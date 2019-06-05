using RE.SistemaFaculdade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Domain.Interfaces.Repository
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Aluno ObterPorEmail(string email);

        IEnumerable<Aluno> ObterPorAtivo();
    }
}
