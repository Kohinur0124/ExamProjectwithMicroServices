using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Application.UseCases.Food.Commands;
using YandexEats.Application.UseCases.Foods.Queries;

namespace YandexEats.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FoodController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllFoods()
        {
            var cards = await _mediator.Send(new GetFoodCommand());
            return Ok(cards);
        }

        [HttpPost]

        public async ValueTask<bool> AddFood(PostFoodCommand postCard)
        {
            var t = await _mediator.Send(postCard);
            return t;
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateFood(PutFoodCommand postUser)
        {
            var t = await _mediator.Send(postUser);
            return Ok(t);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteFood(DeleteFoodCommand postUser)
        {
            var t = await _mediator.Send(postUser);
            return Ok(t);
        }

    }
}
