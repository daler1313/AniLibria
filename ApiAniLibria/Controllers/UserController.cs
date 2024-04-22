using Application.Services;
using AutoMapper;
using Contracts.Requests.Manga;
using Contracts.Requests.User;
using Contracts.Responses.Manga;
using Contracts.Responses.User;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Web.API;

namespace ApiAniLibria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IBaseService<User> _userService;
        private readonly IMapper _mapper;

        public UserController(IBaseService<User> userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken token)
        {
            var entity = _mapper.Map<User>(request);

            var response = await _userService.CreateAsync(entity, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }

        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(int id, CancellationToken token)
        {
            var entityExist = await _userService.GetAsync(id);

            if (entityExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleUserResponse>(entityExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var entity = await _userService.GetAllAsync(token);

            var response = new GetAllUserResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleUserResponse>>(entity)
            };

            return Ok(response);
        }

        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateUserRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            User entity = _mapper.Map<User>(request);

            await _userService.UpdateAsync(entity, token);

            var response = _mapper.Map<SingleUserResponse>(entity);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
        {
            var response = await _userService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"User with ID {id} not found.");
        }
    }
}
