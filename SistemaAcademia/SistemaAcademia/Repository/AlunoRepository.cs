using SistemaAcademia.Dominio;
using System.Data.Entity;

namespace SistemaAcademia.Repository
{
    class AlunoRepository
    {
        public int Save(Aluno aluno)
        {
            if (aluno == null) return 0;

            using (var db = new AppDBContext())
            {
                if (db.Entry(aluno).State == EntityState.Detached)
                {
                    db.Set<Aluno>().Attach(aluno);
                }
                if (aluno.Id == 0)
                {
                    db.Entry(aluno).State = EntityState.Added;
                }
                else
                {
                    db.Entry(aluno).State = EntityState.Modified;
                }
                return db.SaveChanges();
            }
        }
        public int Delete(Aluno aluno)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(aluno).State == EntityState.Detached)
                    db.Set<Aluno>().Attach(aluno);
                db.Entry(aluno).State = EntityState.Deleted;
                return db.SaveChanges();

            }
        }
    }
}
