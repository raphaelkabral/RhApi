using RhApi.Application.IServices;
using RhApi.Domain;
using RhApi.Domain.IRepository;

namespace RhApi.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
    
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Add(User user)
        {
            await _userRepository.AddAsync(user);
            return user;
        }

        public async Task<User> GetById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
                throw new Exception("Usuario não encontrado.");
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<bool> Remove(int id)
        {
           var user = await _userRepository.GetByIdAsync(id);

            if(user == null)
                throw new Exception("Usuario não encontrado.");

            return true;
        }           

        public Task<User> Update(int id, User user)
        {
            var userRepository = _userRepository.GetByIdAsync(id).Result;
            if (userRepository == null)
                throw new Exception("Usuario não encontrado.");
            userRepository = user;
            
            return Task.FromResult(user);
        }
    }
}
