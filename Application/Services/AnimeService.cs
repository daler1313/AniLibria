using Domain.Entity;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class AnimeService: IBaseService<Anime>
    {
        private readonly IBaseRepository<Anime> _AnimeRepository;

        public AnimeService(IBaseRepository<Anime> buildingRepository)
        {
            _AnimeRepository = buildingRepository;
        }

        public async Task<Anime> CreateAsync(Anime building, CancellationToken token = default)
        {
            return await _AnimeRepository.CreateAsync(building, token);
        }

        public async Task<bool> DeleteAsync(Anime animes, CancellationToken token = default)
        {
            return await _AnimeRepository.DeleteAsync(animes, token);
        }

        public async Task<IEnumerable<Anime>> GetAllAsync(CancellationToken token = default)
        {
            return await _AnimeRepository.GetAllAsync(token);
        }

        public async Task<Anime> GetAsync(int id, CancellationToken token = default)
        {
            return await _AnimeRepository.GetAsync(id, token);
        }


        public async Task<bool> UpdateAsync(Anime animes, CancellationToken token = default)
        {
            var existingAnime = await GetAsync(animes.Id);

            if (existingAnime is null)
            {
                return false;
            }

            existingAnime.Name = animes.Name;
            existingAnime.Description = animes.Description;
            existingAnime.Description = animes.Description;
            existingAnime.AuthorId = animes.AuthorId;
            existingAnime.GenreId = animes.GenreId;
            existingAnime.DateOfSsue = animes.DateOfSsue;


            return await _AnimeRepository.UpdateAsync(existingAnime, token);

        } }
}
