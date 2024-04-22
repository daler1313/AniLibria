using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IBaseService<User>
    {
        private readonly IBaseRepository<User> _userRepository;

        public UserService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateAsync(User entity, CancellationToken token = default)
        {
            return await _userRepository.CreateAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var entity = await _userRepository.GetAsync(id, token);

            if (entity == null)
                return false;

            return await _userRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken token = default)
        {
            return await _userRepository.GetAllAsync(token);
        }

        public async Task<User> GetAsync(int id, CancellationToken token = default)
        {
            return await _userRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(User entity, CancellationToken token = default)
        {
            var existingEntity = await GetAsync(entity.Id);

            if (existingEntity is null)
            {
                return false;
            }

            existingEntity.FullName = entity.FullName;
            existingEntity.Email = entity.Email;
            existingEntity.Phone = entity.Phone;

            return await _userRepository.UpdateAsync(existingEntity, token);
        }
    }
}
