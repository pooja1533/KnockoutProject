using ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public interface IUserService
    {
         bool Login(LoginDO loginDO);
    }
}
