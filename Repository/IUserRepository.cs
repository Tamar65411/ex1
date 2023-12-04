using DTO;
using Entities;


namespace Repository
{
    public interface IUserRepository
    {
        Task<UsersTbl> addUser(UsersTbl user);
        Task<UsersTbl> getUserByEmailAndPassword(UserLoginDTO userLoginDTO);
       
        Task updateUser( UsersTbl value);
       
    }
}