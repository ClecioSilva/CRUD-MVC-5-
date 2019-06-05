using AutoMapper;
using RE.SistemaFaculdade.Application.ViewModels;
using RE.SistemaFaculdade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<AlunoViewModel, Aluno>();
            CreateMap<ALCACFPViewModel, Aluno>();
            CreateMap<CustoAlunoViewModel, CustoAluno>();
            CreateMap<ALCACFPViewModel, CustoAluno >();
            CreateMap<CustoFaculdadeViewModel, CustoFaculdade>();
            CreateMap<ALCACFPViewModel, CustoFaculdade>();
            CreateMap<ProfissaoViewModel, Profissao>();
            CreateMap<ALCACFPViewModel, Profissao>();
        }
    }
}
