using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace Application.Services
{
    public class AuthorService : IBaseService<Author>
    {
        private readonly IBaseRepository<Author> _authorRepository;

        public AuthorService(IBaseRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Author> CreateAsync(Author entity, CancellationToken token = default)
        {
            return await _authorRepository.CreateAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var entity = await _authorRepository.GetAsync(id, token);

            if (entity == null)
                return false;

            return await _authorRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Author>> GetAllAsync(CancellationToken token = default)
        {
            return await _authorRepository.GetAllAsync(token);
        }

        public async Task<Author> GetAsync(int id, CancellationToken token = default)
        {
            return await _authorRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Author entity, CancellationToken token = default)
        {
            var existingEntity = await GetAsync(entity.Id);

            if (existingEntity is null)
            {
                return false;
            }

            existingEntity.FullName = entity.FullName;
            existingEntity.YearOfDirth = entity.YearOfDirth;

            return await _authorRepository.UpdateAsync(existingEntity, token);
        }
    }
}
