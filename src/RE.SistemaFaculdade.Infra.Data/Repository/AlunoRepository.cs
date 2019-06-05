using RE.SistemaFaculdade.Domain.Entities;
using RE.SistemaFaculdade.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using RE.SistemaFaculdade.Infra.Data.Repository;




namespace RE.SistemaFaculdade.Infra.Data.Repository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {


        public Aluno ObterPorEmail(string email)
        {
            return Buscar(a => a.Email == email).FirstOrDefault();
        }

        public IEnumerable<Aluno> ObterPorAtivo()
        {
            return Buscar(a => a.Ativo);
        }

        public override void Remover(Guid id)
        {
            var aluno = ObterPorId(id);
            aluno.Ativo = false;
            Atualizar(aluno);
        }

        public void Adicionar(Aluno aluno, CustoAluno custoaluno)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(CustoFaculdade custofaculdade)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Profissao profissao)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Aluno> ObterTodos()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM Alunos";

            return cn.Query<Aluno>(sql);
        }

        public void Adicionar(CustoAluno custoaluno)
        {
            throw new NotImplementedException();
        }

        public override Aluno ObterPorId(Guid id)
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM Alunos a " +
                "LEFT JOIN CustoAlunos ca " +
                "ON a.AlunoId = ca.AlunoId " +
                "WHERE a.AlunoId = @sid";

            var aluno = cn.Query<Aluno, CustoAluno, Aluno>(sql,
                (a, ca) =>
                {
                    a.CustoAlunos.Add(ca);
                    return a;
                }, new { sid = id }, splitOn: "AlunoId, CustoAlunoId ");

            return aluno.FirstOrDefault();
        }
    }       
}

