using RhApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhApi.Application.IServices
{
    public interface IUserService
    {
        Task<User> Add(User user);
        Task<User> Update(int id, User user);
        Task<bool> Remove(int id);
        Task<User> GetById(int id);
        Task<IEnumerable<User>> GetUsers();
    }
}
