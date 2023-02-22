using DataModel.Models;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ServiceModel.Converter
{
    public class UserConverter
    {
        public static User ConvertLoginDetial(LoginDO loginDO)
        {
            return new User
            {
                Email = loginDO.Email,
                Password = loginDO.Password
            };
        }
    }
}
