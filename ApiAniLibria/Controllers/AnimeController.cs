using Application.Services;
using AutoMapper;
using Contracts.Requests.Anime;
using Contracts.Responses.Anime;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController : Controller
    {
        private readonly IBaseService<Anime> _animeService;
        private readonly IMapper _mapper;
        private readonly ILogger<AnimeController> _logger;

        public AnimeController(IMapper mapper, IBaseService<Anime> animeService, ILogger<AnimeController> logger)
        {
            _animeService = animeService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateAnimeRequest request, CancellationToken token)
        {
            _logger.LogInformation("Создать запрос получен");

            try
            {
                var anime = _mapper.Map<Anime>(request);
                var response = await _animeService.CreateAsync(anime, token);
                _logger.LogInformation("Anime создано с ID: {Id}", response.Id);
                return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Произошла ошибка при создании anime.");
                return StatusCode(500, "Во время обработки запроса произошла ошибка.");
            }
        }

        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(int id, CancellationToken token)
        {
            _logger.LogInformation("Get запрос получен на ID: {Id}", id);

            try
            {
                var animeExist = await _animeService.GetAsync(id);
                if (animeExist == null)
                {
                    _logger.LogWarning("Anime не найден для ID: {Id}", id);
                    return NotFound();
                }

                var response = _mapper.Map<SingleAnimeResponse>(animeExist);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Произошла ошибка при получении аниме с помощью ID: {Id}", id);
                return StatusCode(500, "Во время обработки Вашего запроса произошла ошибка.");
            }
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            _logger.LogInformation("GetAll Запрос получен");

            try
            {
                var anime = await _animeService.GetAllAsync(token);
                var response = new GetAllAnimeResponse
                {
                    Items = _mapper.Map<IEnumerable<SingleAnimeResponse>>(anime)
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Произошла ошибка при получении всех anime.");
                return StatusCode(500, "Во время обработки запроса произошла ошибка.");
            }
        }

        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateAnimeRequest request, CancellationToken token)
        {
            _logger.LogInformation("Получен запрос на обновление для ID: {Id}", id);

            if (request == null)
            {
                _logger.LogWarning("Неверные данные запроса на обновление запроса ID: {Id}", id);
                return BadRequest("Неверные данные запроса.");
            }

            try
            {
                var anime = _mapper.Map<Anime>(request);
                await _animeService.UpdateAsync(anime, token);
                var response = _mapper.Map<SingleAnimeResponse>(anime);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Произошла ошибка при обновлении аниме с помощью ID: {Id}", id);
                return StatusCode(500, "Во время обработки Вашего запроса произошла ошибка.");
            }
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
        {
            _logger.LogInformation("Получен запрос на удаление для ID: {Id}", id);

            try
            {
                var response = await _animeService.DeleteAsync(id, token);
                if (response)
                {
                    _logger.LogInformation("Anime с ID: {Id} успешно удалено", id);
                    return Ok();
                }
                else
                {
                    _logger.LogWarning("Anime с ID: {Id} не найдено", id);
                    return NotFound($"Anime with ID {id} не найдено");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Произошла ошибка при удалении аниме с помощью ID: {Id}", id);
                return StatusCode(500, "Во время обработки Вашего запроса произошла ошибка.");
            }
        }
    }
}
