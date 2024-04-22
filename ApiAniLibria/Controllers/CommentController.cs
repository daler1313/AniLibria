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
    public class CommentController : Controller
    {
        private readonly IBaseService<Comment> _commentService;
        private readonly IMapper _mapper;

        public CommentController(IBaseService<Comment> commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateCommentRequest request, CancellationToken token)
        {
            var comment = _mapper.Map<Comment>(request);

            var response = await _commentService.CreateAsync(comment, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }



        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(int id, CancellationToken token)
        {
            var commentExist = await _commentService.GetAsync(id);

            if (commentExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleCommentResponse>(commentExist);

            return response == null ? NotFound() : Ok(response);
        }


        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var comment = await _commentService.GetAllAsync(token);

            var response = new GetAllCommentResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleCommentResponse>>(comment)
            };

            return Ok(response);
        }

        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCommentRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Comment comment = _mapper.Map<Comment>(request);

            await _commentService.UpdateAsync(comment, token);

            var response = _mapper.Map<SingleGenreResponse>(comment);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
        {
            var response = await _commentService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Comment with ID {id} not found.");
        }
    }
}
