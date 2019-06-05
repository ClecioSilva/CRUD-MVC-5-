using RE.SistemaFaculdade.Domain.Entities;
using RE.SistemaFaculdade.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;

namespace RE.SistemaFaculdade.Infra.Data.Context
{
    public class SistemaFaculdadeContext : DbContext
    {
        public  SistemaFaculdadeContext()
            :base ("DefaultConnection")
        {

        }

        public virtual DbSet<Aluno>Alunos { get; set; }
        public virtual DbSet<CustoAluno>CustoAlunos { get; set; }
        public virtual DbSet<CustoFaculdade> CustoFaculdades { get; set; }
        public virtual DbSet<Profissao> Profissaos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AlunoConfig());
            modelBuilder.Configurations.Add(new CustoAlunoConfig());
            modelBuilder.Configurations.Add(new CustoFaculdadeConfig());
            modelBuilder.Configurations.Add(new ProfissaoConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();            
        }

    }
}
