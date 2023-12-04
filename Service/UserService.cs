using DTO;
using Entities;

using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zxcvbn;


namespace Service
{
    public class UserService : IUserService
    {
        IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }
        public async Task<UsersTbl> getUserByEmailAndPassword(UserLoginDTO userLoginDTO)
        {
            return await repository.getUserByEmailAndPassword(userLoginDTO);
        }
    

    public async Task<UsersTbl> addUser(UsersTbl user)
        {
            int level = checkPassword(user.Password);
            if (level > 2)
                return await repository.addUser(user);
            return null;
        }


        public async Task updateUser( UsersTbl value)
        {
            await repository.updateUser( value);
        }
        public int checkPassword(string password)
        {
            var result = Zxcvbn.Core.EvaluatePassword(password);
            return result.Score;
        }

    }
}
