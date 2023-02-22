using DataModel.ServiceModel.Converter;
using RepositoryInterface;
using ServiceInterfaces;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public class UserService:IUserService
    {
        private IUserRepository _repo;
        public UserService(IUserRepository userRepository)
        {
            this._repo = userRepository;
        }
        public bool Login(LoginDO loginDO)
        {
            var user = UserConverter.ConvertLoginDetial(loginDO);
            var result = _repo.Login(user);
            return result;
        }
    }
}
