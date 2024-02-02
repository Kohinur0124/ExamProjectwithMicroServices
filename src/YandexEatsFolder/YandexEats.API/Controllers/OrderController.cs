using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Application.UseCases.Order.Commands;
using YandexEats.Application.UseCases.Order.Queries;

namespace YandexEats.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllOrder()
        {
            var cards = await _mediator.Send(new GetOrderCommand());
            return Ok(cards);
        }

        [HttpPost]

        public async ValueTask<bool> AddOrder(PostOrderCommand posts)
        {
            var t = await _mediator.Send(posts);
            return t;
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateOrder(PutOrderCommand posts)
        {
            var t = await _mediator.Send(posts);
            return Ok(t);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteOrder(DeleteOrderCommand posts)
        {
            var t = await _mediator.Send(posts);
            return Ok(t);
        }
    }
}
