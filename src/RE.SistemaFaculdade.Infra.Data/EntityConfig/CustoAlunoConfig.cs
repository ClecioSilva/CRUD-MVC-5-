using RE.SistemaFaculdade.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;


namespace RE.SistemaFaculdade.Infra.Data.EntityConfig
{
    //fluent API
    public class CustoAlunoConfig : EntityTypeConfiguration<CustoAluno>
    {
        public CustoAlunoConfig()
        {
            HasKey(ca => ca.CustoAlunoId);            

            Property(ca => ca.Transporte)
                .IsRequired();

            Property(ca => ca.Alimentacao)
                .IsRequired();


            Property(ca => ca.Aluguel)
                .IsRequired();

            Property(ca => ca.Agua)
                .IsRequired();

            Property(ca => ca.Luz)
                .IsRequired();

            Property(ca => ca.Gaz)
                .IsRequired();

            Property(ca => ca.Internet)
                .IsRequired();

            Property(ca => ca.Roupa)
                .IsRequired();
                
            HasRequired(ca => ca.Aluno)
                .WithMany(a => a.CustoAlunos)
                .HasForeignKey(ca => ca.AlunoId);

           
            ToTable("CustoAlunos");
        }
    }
}
