using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterface
{
    public interface IBaseRepository
    {
        DataContext GetContext();
        void Add<TEntity>(TEntity entity) where TEntity : class;
        void Commit();
        void Delete<TEntity>(TEntity entity) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;

    }
}
