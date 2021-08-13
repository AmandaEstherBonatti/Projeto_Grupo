using SistemaAcademia.Dominio;
using System.Data.Entity;

namespace SistemaAcademia.Repository
{
    class ModalidadeRepository
    {
        public int Save(Modalidade modalidade)
        {
            if (modalidade == null) return 0;

            using (var db = new AppDBContext())
            {
                if (db.Entry(modalidade).State == EntityState.Detached)
                {
                    db.Set<Modalidade>().Attach(modalidade);
                }
                if (modalidade.IdModalidade == 0)
                {
                    db.Entry(modalidade).State = EntityState.Added;
                }
                else
                {
                    db.Entry(modalidade).State = EntityState.Modified;
                }
                return db.SaveChanges();
            }
        }
        public int Delete(Modalidade modalidade)
        {
            using (var db = new AppDBContext())
            {
                if (db.Entry(modalidade).State == EntityState.Detached)
                    db.Set<Modalidade>().Attach(modalidade);
                db.Entry(modalidade).State = EntityState.Deleted;
                return db.SaveChanges();
            }
        }
    }
}
