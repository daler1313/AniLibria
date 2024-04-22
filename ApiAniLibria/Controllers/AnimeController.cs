using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController : Controller
    {
        private readonly IBaseService<Anime> _AnimeService;
        private readonly IMapper _mapper;

        public AnimeController(IMapper mapper, IBaseService<Anime> AnimeService)
        {
            _AnimeService = AnimeService;
            _mapper = mapper;
        }

        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateAnimeRequest request, CancellationToken token)
        {
            var anime = _mapper.Map<Anime>(request);

            var response = await _AnimeService.CreateAsync(anime, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);

        }
        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(int id, CancellationToken token)
        {
            var AnimeExist = await _AnimeService.GetAsync(id);

            if (AnimeExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleAnimeResponse>(AnimeExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var anime = await _AnimeService.GetAllAsync(token);

            var response = new GetAllAnimeResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleAnimeResponse>>(anime)
            };

            return Ok(response);
        }

        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateAnimeRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Anime anime = _mapper.Map<Anime>(request);

            await _AnimeService.UpdateAsync(anime, token);

            var response = _mapper.Map<SingleAnimeResponse>(anime);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
        {
            var response = await _AnimeService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Anime with ID {id} not found.");
        }
    }
}
