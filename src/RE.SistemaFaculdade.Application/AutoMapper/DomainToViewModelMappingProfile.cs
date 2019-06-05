using AutoMapper;
using RE.SistemaFaculdade.Application.ViewModels;
using RE.SistemaFaculdade.Domain.Entities;

namespace RE.SistemaFaculdade.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<Aluno, ALCACFPViewModel>();
            CreateMap<CustoAluno, CustoAlunoViewModel>();
            CreateMap<CustoAluno, ALCACFPViewModel>();
            CreateMap<CustoFaculdade, CustoFaculdadeViewModel>();
            CreateMap<CustoFaculdade, ALCACFPViewModel>();
            CreateMap<Profissao, ProfissaoViewModel>();
            CreateMap<Profissao, ALCACFPViewModel>();
        }
    }
}
