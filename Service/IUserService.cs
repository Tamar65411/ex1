using DTO;
using Entities;


namespace Service
{
    public interface IUserService
    {
        Task<UsersTbl> addUser(UsersTbl user);
        int checkPassword(string password);
        Task<UsersTbl> getUserByEmailAndPassword(UserLoginDTO userLoginDTO);
      
        Task updateUser(UsersTbl value);
    
    }
}