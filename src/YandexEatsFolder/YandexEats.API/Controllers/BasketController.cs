using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Application.UseCases.Basket.Commands;
using YandexEats.Application.UseCases.Basket.Queries;
using YandexEats.Application.UseCases.Card.Commands;
using YandexEats.Application.UseCases.Card.Queries;
using YandexEats.Application.UseCases.User.Commands;

namespace YandexEats.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BasketController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllBaskets()
        {
            var cards = await _mediator.Send(new GetBasketCommand());
            return Ok(cards);
        }

        [HttpPost]

        public async ValueTask<bool> AddBasket(PostBasketCommand postCard)
        {
            var t = await _mediator.Send(postCard);
            return t;
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateBasket(PutBasketCommand postUser)
        {
            var t = await _mediator.Send(postUser);
            return Ok(t);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteBasket(DeleteBasketCommand postUser)
        {
            var t = await _mediator.Send(postUser);
            return Ok(t);
        }

    }
}
