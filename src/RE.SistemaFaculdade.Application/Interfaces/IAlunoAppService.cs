using RE.SistemaFaculdade.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Application.Interfaces
{
    public interface IAlunoAppService : IDisposable
    {
        ALCACFPViewModel Adicionar(ALCACFPViewModel aLCACFPViewModel);

        AlunoViewModel ObterPorId(Guid id);

        AlunoViewModel ObterPorEmail(string email);

        IEnumerable<AlunoViewModel> ObterTodos();

        AlunoViewModel Atualizar(AlunoViewModel alunoViewModel);

        void Remover(Guid id);
    }
}
