using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosApp.Domain.Interfaces
{
    /// <summary> 
    /// Repositório genérico para definir as operações principais de banco de dados 
    /// </summary>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll();
        TEntity? GetById(Guid id);
    }
}