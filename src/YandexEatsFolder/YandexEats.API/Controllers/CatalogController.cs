using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Application.UseCases.Catalog.Commands;
using YandexEats.Application.UseCases.Catalog.Queries;

namespace YandexEats.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CatalogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllCatalog()
        {
            var cards = await _mediator.Send(new GetCatalogCommand());
            return Ok(cards);
        }

        [HttpPost]

        public async ValueTask<bool> AddCatalog(PostCatalogCommand posts)
        {
            var t = await _mediator.Send(posts);
            return t;
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateCatalog(PutCatalogCommand posts)
        {
            var t = await _mediator.Send(posts);
            return Ok(t);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteCatalog(DeleteCatalogCommand posts)
        {
            var t = await _mediator.Send(posts);
            return Ok(t);
        }
    }
}
