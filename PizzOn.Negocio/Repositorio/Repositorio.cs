using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PizzON.Negocio.Repositorio
{
    public interface IRepositorio<TEntidad> where TEntidad : class
    {
        TContext ContextoDB<TContext>() where TContext : DbContext;

        //Metodos de la interfaz
        void Add(TEntidad entity);

        TEntidad Get(int id);

        void Delete(TEntidad entity);

        void Edit(TEntidad entity);

        IEnumerable<TEntidad> GetAll(Expression<Func<TEntidad, bool>> predicate = null);

        TEntidad GetOne(String id);
    }


    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : class
    {
        //Contexto al que vmaos a realizar las operaciones
        protected readonly DbContext Contexto;

        //Constructor
        public Repositorio(DbContext context)
        {
            Contexto = context;
        }

        public TContext ContextoDB<TContext>() where TContext : DbContext
        {
            return Contexto as TContext;
        }

        //Metodos genericos
        public virtual void Add(TEntidad entitiy)
        {
            Contexto.Set<TEntidad>().Add(entitiy);
        }

        public virtual void Delete(TEntidad entity)
        {
            Contexto.Set<TEntidad>().Attach(entity);
            Contexto.Set<TEntidad>().Remove(entity);
        }

        public virtual TEntidad Get(int id)
        {
            return Contexto.Set<TEntidad>().Find(id);
        }

        public virtual void Edit(TEntidad entity)
        {
            Contexto.Set<TEntidad>().Attach(entity);
            Contexto.Entry<TEntidad>(entity).State = EntityState.Modified;
        }

        public virtual IEnumerable<TEntidad> GetAll(Expression<Func<TEntidad, bool>> predicate = null)
        {
            if (predicate != null)
                return Contexto.Set<TEntidad>().AsNoTracking().Where(predicate).ToList();
            else
                return Contexto.Set<TEntidad>().AsNoTracking().ToList();
        }

        public virtual TEntidad GetOne(String id)
        {
            return Contexto.Set<TEntidad>().Find(id);
        }
    }
}
