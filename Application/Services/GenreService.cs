using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class GenreService : IBaseService<Genre>
    {
        private readonly IBaseRepository<Genre> _genreRepository;

        public GenreService(IBaseRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<Genre> CreateAsync(Genre entity, CancellationToken token = default)
        {
            return await _genreRepository.CreateAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var entity = await _genreRepository.GetAsync(id, token);

            if (entity == null)
                return false;

            return await _genreRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Genre>> GetAllAsync(CancellationToken token = default)
        {
            return await _genreRepository.GetAllAsync(token);
        }

        public async Task<Genre> GetAsync(int id, CancellationToken token = default)
        {
            return await _genreRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Genre entity, CancellationToken token = default)
        {
            var existingEntity = await GetAsync(entity.Id);

            if (existingEntity is null)
            {
                return false;
            }

            existingEntity.Name = entity.Name;
            existingEntity.Type = entity.Type;

            return await _genreRepository.UpdateAsync(existingEntity, token);
        }
    }
}
