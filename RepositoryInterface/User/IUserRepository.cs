using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterface
{
    public interface IUserRepository
    {
        bool Login(User user);
    }
}
