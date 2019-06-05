using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace RE.SistemaFaculdade.Infra.Data.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<RE.SistemaFaculdade.Infra.Data.Context.SistemaFaculdadeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RE.SistemaFaculdade.Infra.Data.Context.SistemaFaculdadeContext context)
        {
      
        }
    }
}
