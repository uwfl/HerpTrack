using HerpTrack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Repo.Interfaces
{
    public interface IAuthRepository<T> where T : BaseIdentityEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
