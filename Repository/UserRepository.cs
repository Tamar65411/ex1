using DTO;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private  StoreDataBase2Context dbContext;

        public UserRepository(StoreDataBase2Context dbContext)
        {
            this.dbContext = dbContext;
        }
     



        public async Task<UsersTbl> getUserByEmailAndPassword(UserLoginDTO userLoginDTO)
        {
            return await dbContext.UsersTbls.Where(e => e.Password == userLoginDTO.Password && e.Email == userLoginDTO.Email).FirstOrDefaultAsync();
        }


        public async Task<UsersTbl> addUser(UsersTbl user)
        {
           await dbContext.UsersTbls.AddAsync(user);
           await dbContext.SaveChangesAsync();
            return user;


        }


        public async Task updateUser(UsersTbl newUser)
        {

           dbContext.UsersTbls.Update(newUser);
           await dbContext.SaveChangesAsync();
        }


    }
}
