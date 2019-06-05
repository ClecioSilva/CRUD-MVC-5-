using RE.SistemaFaculdade.Application.Interfaces;
using RE.SistemaFaculdade.Application.ViewModels;
using RE.SistemaFaculdade.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RE.SistemaFaculdade.Domain.Entities;

namespace RE.SistemaFaculdade.Application
{
    public class AlunoAppService : IAlunoAppService
    {
        private readonly AlunoRepository _alunoRepository;

        public AlunoAppService()
        {
            _alunoRepository = new AlunoRepository();
        }

        public ALCACFPViewModel Adicionar(ALCACFPViewModel aLCACFPViewModel)
        {
            var aluno = Mapper.Map<Aluno>(aLCACFPViewModel);
            var custoaluno = Mapper.Map<CustoAluno>(aLCACFPViewModel);
            var custofaculdade = Mapper.Map<CustoFaculdade>(aLCACFPViewModel);
            var profissao = Mapper.Map<Profissao>(aLCACFPViewModel);

            aluno.CustoAlunos.Add(custoaluno);
            aluno.CustoFaculdades.Add(custofaculdade);
            aluno.Profissaos.Add(profissao);

            aluno.DataCadastro = DateTime.Now;

            _alunoRepository.Adicionar(aluno);
          //  _alunoRepository.Adicionar(custoaluno);
          //  _alunoRepository.Adicionar(custofaculdade);
          //  _alunoRepository.Adicionar(profissao);

            return aLCACFPViewModel;
        }

        public AlunoViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<AlunoViewModel>(_alunoRepository.ObterPorId(id));
        }

        public IEnumerable<AlunoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<AlunoViewModel>>(_alunoRepository.ObterPorAtivo());
        }

        public AlunoViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<AlunoViewModel>(_alunoRepository.ObterPorEmail(email));
        }

        public AlunoViewModel Atualizar(AlunoViewModel alunoViewModel)
        {
            var aluno = Mapper.Map<Aluno>(alunoViewModel);
            _alunoRepository.Atualizar(aluno);            
            return alunoViewModel;
        }    
        
        public void Remover(Guid id)
        {
            _alunoRepository.Remover(id);
        }

        public void Dispose()
        {
            _alunoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Atualizar(CustoAlunoViewModel custoalunoViewModel)
        {
            throw new NotImplementedException();
        }

        ALCACFPViewModel IAlunoAppService.Adicionar(ALCACFPViewModel aLCACFPViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
