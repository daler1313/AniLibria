using Application.Services;
using AutoMapper;
using Contracts.Requests.Author;
using Contracts.Responses.Author;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Web.API;

namespace ApiAniLibria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : Controller
    {
        private readonly IBaseService<Author> _authorService;
        private readonly IMapper _mapper;
        public AuthorController(IBaseService<Author> authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }
        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateAuthorRequest request, CancellationToken token)
        {
            var author = _mapper.Map<Author>(request);

            var response = await _authorService.CreateAsync(author, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);

        }


        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(int id, CancellationToken token)
        {
            var authorExist = await _authorService.GetAsync(id);

            if (authorExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleAuthorResponse>(authorExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var author = await _authorService.GetAllAsync(token);

            var response = new GetAllAuthorResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleAuthorResponse>>(author)
            };

            return Ok(response);
        }

        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateAuthorRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Author author = _mapper.Map<Author>(request);

            await _authorService.UpdateAsync(author, token);

            var response = _mapper.Map<SingleAuthorResponse>(author);

            return response == null ? NotFound() : Ok(response);
        }
        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
        {
            var response = await _authorService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Author with ID {id} not found.");
        }

    }
}
