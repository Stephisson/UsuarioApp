using System;
using System.Collections.Generic;
using System.Text;
using UsuariosApp.Domain.Interfaces;
using UsuariosApp.Infra.Data.Contexts;

namespace UsuariosApp.Infra.Data.Repositories
{
    /// <summary> 
    /// Classe de repositório genérico para o banco de dados 
    /// </summary>
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        public void Add(TEntity entity)
        {
            using (var dataContext = new DataContext()) 
            {
                dataContext.Add(entity); //inserindo
                dataContext.SaveChanges(); //executando
            }
        }

        public void Delete(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(entity); //excluindo
                dataContext.SaveChanges(); //executando
            }
        }

        public void Update(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Update(entity); //atualizando
                dataContext.SaveChanges(); //executando
                
            }
        }

        public List<TEntity> GetAll()
        {
            using (var dataContext = new DataContext()) 
            { 
                return dataContext.Set<TEntity>().ToList(); 
            }
        }

        public TEntity? GetById(Guid id)
        {
            using (var dataContext = new DataContext()) 
            { 
                return dataContext.Set<TEntity>().Find(id); 
            }
        }       
    }
}