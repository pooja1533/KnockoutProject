using DataModel.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public partial class BaseRepository : IBaseRepository
    {
        private DataContext dataContext;
        public BaseRepository(DataContext datacontext)
        {
            this.dataContext = datacontext;
        }
        public DataContext GetContext()
        {
            return this.dataContext;
        }
        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            dataContext.Set<TEntity>().Add(entity);
        }
        public void Commit()
        {
            dataContext.SaveChanges();

        }
        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            dataContext.Set<TEntity>().Remove(entity);
        }
        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            dataContext.Entry<TEntity>(entity).State = EntityState.Modified;
        }
    }
}
