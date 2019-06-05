using RE.SistemaFaculdade.Domain.Entities;
using System.Data.Entity.ModelConfiguration;


namespace RE.SistemaFaculdade.Infra.Data.EntityConfig
{
    public class ProfissaoConfig : EntityTypeConfiguration<Profissao>
    {
        public ProfissaoConfig()
        {
            HasKey(p => p.ProfissaoId);

            Property(p => p.Empresa)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Cargo)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Salario)
                .IsRequired();

            HasRequired(p => p.Aluno)
                .WithMany(a => a.Profissaos)
                .HasForeignKey(p => p.AlunoId);

                       
            ToTable("Profissao");
        }
    }
}

