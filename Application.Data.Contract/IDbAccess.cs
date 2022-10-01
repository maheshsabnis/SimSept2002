using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Model.Entity;
using Application.Model.Entity.Base;

namespace Application.Data.Contract
{
    /// <summary>
    /// The Generic Interface tht will Contain Generic Methods
    /// for CRUD Operations on Entity Classes e.g. Category and Product
    /// TEntity: Is a Generic Type Parameter and currently TEntity is restrcicted 
    /// to use either EntityBase or any class Derived from EntityBase
    /// 
    /// The 'in' means that the 'TPk' will always be an input parameter 
    /// for a method
    /// </summary>
    /// <typeparam name="TEnity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    public interface IDbAccess<TEntity, in TPk> where TEntity : EntityBase
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TPk id);
        TEntity Create(TEntity enity);
        TEntity Update(TPk id, TEntity enity);
        TEntity Delete(TPk id);
    }
}
