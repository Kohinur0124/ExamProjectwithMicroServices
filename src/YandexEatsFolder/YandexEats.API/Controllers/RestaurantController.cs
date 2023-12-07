using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Application.UseCases.Resturaunt.Commands;
using YandexEats.Application.UseCases.Resturaunt.Queries;

namespace YandexEats.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllRestaurant()
        {
            var cards = await _mediator.Send(new GetResturauntCommand());
            return Ok(cards);
        }

        [HttpPost]

        public async ValueTask<bool> AddRestaurant(PostResturauntCommand postCard)
        {
            var t = await _mediator.Send(postCard);
            return t;
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateRestaurant(PutResturauntCommand postUser)
        {
            var t = await _mediator.Send(postUser);
            return Ok(t);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteRestaurant(DeleteResturauntCommand postUser)
        {
            var t = await _mediator.Send(postUser);
            return Ok(t);
        }
    }
}
