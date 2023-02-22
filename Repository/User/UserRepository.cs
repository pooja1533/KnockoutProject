using DataModel.Models;
using RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private IBaseRepository baseRepository;
        public UserRepository(IBaseRepository baserepository)
        {
            this.baseRepository = baserepository;
        }
        public bool Login(User user)
        {
            var context = baseRepository.GetContext();
            var data = context.User.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
            if (data != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
