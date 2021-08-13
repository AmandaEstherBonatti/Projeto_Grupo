using SistemaAcademia.Dominio;
using System.Data.Entity;

namespace SistemaAcademia.Repository
{
    class ProfessorRepository
    {
        public int Save(Professor professor)
        {
            if (professor == null) return 0;

            using (var db = new AppDBContext())
            {
                if (db.Entry(professor).State == EntityState.Detached)
                {
                    db.Set<Professor>().Attach(professor);
                }
                if (professor.Id == 0)
                {
                    db.Entry(professor).State = EntityState.Added;
                }
                else
                {
                    db.Entry(professor).State = EntityState.Modified;
                }
                return db.SaveChanges();
            }
        }
        public int Delete(Professor professor)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(professor).State == EntityState.Detached)
                    db.Set<Professor>().Attach(professor);
                db.Entry(professor).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }
    }
}
