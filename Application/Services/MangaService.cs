using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MangaService : IBaseService<Manga>
    {
        private readonly IBaseRepository<Manga> _mangaRepository;

        public MangaService(IBaseRepository<Manga> mangaRepository)
        {
            _mangaRepository = mangaRepository;
        }

        public async Task<Manga> CreateAsync(Manga entity, CancellationToken token = default)
        {
            return await _mangaRepository.CreateAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var entity = await _mangaRepository.GetAsync(id, token);

            if (entity == null)
                return false;

            return await _mangaRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Manga>> GetAllAsync(CancellationToken token = default)
        {
            return await _mangaRepository.GetAllAsync(token);
        }

        public async Task<Manga> GetAsync(int id, CancellationToken token = default)
        {
            return await _mangaRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Manga entity, CancellationToken token = default)
        {
            var existingEntity = await GetAsync(entity.Id);

            if (existingEntity is null)
            {
                return false;
            }

            existingEntity.Name = entity.Name;
            existingEntity.Description = entity.Description;
            existingEntity.GenreId = entity.GenreId;
            existingEntity.AuthorId = entity.AuthorId;
            existingEntity.DateOfSsue = entity.DateOfSsue;
        

            return await _mangaRepository.UpdateAsync(existingEntity, token);
        }
    }
}
