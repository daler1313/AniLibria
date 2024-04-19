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
            var building = _mapper.Map<Anime>(request);

            var response = await _AnimeService.CreateAsync(building, token);
            return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
        }

        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
        {
            var AnimeExist = await _AnimeService.GetAsync(id);

            if (AnimeExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleAnimeResponse>(AnimeExist);

            return response == null ? NotFound() : Ok(response);
        }
    }
}
