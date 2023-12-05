using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Application.UseCases.Cards.Commands;
using YandexEats.Application.UseCases.Cards.Queries;
using YandexEats.Application.UseCases.Users.Queries;

namespace YandexEats.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CardsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllCards()
        {
            var cards = await _mediator.Send(new GetCardCommand());
            return Ok(cards);
        }

        [HttpPost]

        public async ValueTask<bool> AddCard(PostCardCommand postCard)
        {
            var t = await _mediator.Send(postCard);
            return t;
        }

    }
}
