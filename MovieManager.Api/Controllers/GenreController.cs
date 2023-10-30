using Microsoft.AspNetCore.Mvc;
using MovieManager.Contract.Requests;
using MovieManager.Contract.Responses;
using MovieManager.Service.Commands;
using MovieManager.Service;

namespace MovieManager.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[Controller]")]
    [ApiController]

    public class GenreController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> UpsertGenreAsync([FromServices] IRequestHandler<IList<GenreResponse>> getGenreQuery)
        {
            return Ok(await getGenreQuery.Handle());
        }

        [HttpPost]
        public async Task<IActionResult> UpsertGenreAsync([FromServices] IRequestHandler<UpsertGenreCommand, GenreResponse> upsertGenreCommand, [FromBody] UpsertGenreCommand request)
        {
            var genre = await upsertGenreCommand.Handle(new UpsertGenreCommand
            {
                GenreId = request.GenreId,
                GenreName = request.GenreName
            });

            return Ok(genre);
        }
    }
}
