using RE.SistemaFaculdade.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;


namespace RE.SistemaFaculdade.Infra.Data.EntityConfig
{
    //fluent API
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfig()
        {
            HasKey(a => a.AlunoId);
            //HasKey(a => new { a.AlunoId, a.Email });

            Property(a => a.Nome)
                .IsRequired()
                .HasColumnOrder(1)
                .HasMaxLength(150)
                .HasColumnType("varchar")
                .HasColumnName("Nome");

            Property(a => a.Tel)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(a => a.DataCadastro)
                .IsRequired();

            Property(a => a.Ativo)
                .IsRequired();

            ToTable("Alunos");
        }
    }
}
