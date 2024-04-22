using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CommentService : IBaseService<Comment>
    {
        private readonly IBaseRepository<Comment> _commentRepository;

        public CommentService (IBaseRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<Comment> CreateAsync(Comment entity, CancellationToken token = default)
        {
            return await _commentRepository.CreateAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var entity = await _commentRepository.GetAsync(id, token);

            if (entity == null)
                return false;

            return await _commentRepository.DeleteAsync(entity, token);
        }

        public async  Task<IEnumerable<Comment>> GetAllAsync(CancellationToken token = default)
        {
            return await _commentRepository.GetAllAsync(token);
        }

        public async Task<Comment> GetAsync(int id, CancellationToken token = default)
        {
            return await _commentRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Comment entity, CancellationToken token = default)
        {
            var existingEntity = await GetAsync(entity.Id);

            if (existingEntity is null)
            {
                return false;
            }

            existingEntity.Title = entity.Title;
            

            return await _commentRepository.UpdateAsync(existingEntity, token);
        }
    }
}
