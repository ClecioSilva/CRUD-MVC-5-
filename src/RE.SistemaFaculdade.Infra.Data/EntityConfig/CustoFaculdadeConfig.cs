using RE.SistemaFaculdade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE.SistemaFaculdade.Infra.Data.EntityConfig
{
    public class CustoFaculdadeConfig : EntityTypeConfiguration<CustoFaculdade>
    {
        public CustoFaculdadeConfig()
        {
            HasKey(cf => cf.CustoFaculdadeId);


            Property(cf => cf.NomeFacul)
                .IsRequired()
                .HasMaxLength(100);
            

            Property(cf => cf.Instituicao)
                .IsRequired()
                .HasMaxLength(100);

            Property(cf => cf.Curso)
                .IsRequired()
                .HasMaxLength(100);


            Property(cf => cf.Bolca)
                .IsRequired();

            Property(cf => cf.ValorFaculdade)
                .IsRequired();

            Property(cf => cf.MaterialAuxilio)
                .IsRequired();   
            

            HasRequired(cf => cf.Aluno)
                .WithMany(a => a.CustoFaculdades)
                .HasForeignKey(cf => cf.AlunoId);


            ToTable("CustoFaculdade");
        }
    }
}
