using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Web.API;

namespace ApiAniLibria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MangaController : Controller
    {
        private readonly IBaseService<Manga> _mangaService;
        private readonly IMapper _mapper;

        public MangaController(IBaseService<Manga> mangaService, IMapper mapper)
        {
            _mangaService = mangaService;
            _mapper = mapper;
        }
        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateMangaRequest request, CancellationToken token)
        {
            var manga = _mapper.Map<Manga>(request);

            var response = await _mangaService.CreateAsync(manga, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }

        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(int id, CancellationToken token)
        {
            var entityExist = await _mangaService.GetAsync(id);

            if (entityExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleMangaResponse>(entityExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var entity = await _mangaService.GetAllAsync(token);

            var response = new GetAllMangaResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleMangaResponse>>(entity)
            };

            return Ok(response);
        }

        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateMangaRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Manga entity = _mapper.Map<Manga>(request);

            await _mangaService.UpdateAsync(entity, token);

            var response = _mapper.Map<SingleMangaResponse>(entity);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
        {
            var response = await _mangaService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Manga with ID {id} not found.");
        }
    }
}
