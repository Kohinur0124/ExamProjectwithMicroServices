using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Application.UseCases.Customer.Commands;
using YandexEats.Application.UseCases.Customer.Queries;

namespace YandexEats.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllCustomer()
        {
            var cards = await _mediator.Send(new GetCustomerCommand());
            return Ok(cards);
        }
        [HttpPost]

        public async ValueTask<bool> AddCustomer(PostCustomerCommand posts)
        {
            var t = await _mediator.Send(posts);
            return t;
        }
        [HttpPut]

        public async ValueTask<IActionResult> UpdateCustomer(PutCustomerCommand posts)
        {
            var t = await _mediator.Send(posts);
            return Ok(t);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteCustomer(DeleteCustomerCommand posts)
        {
            var t = await _mediator.Send(posts);
            return Ok(t);
        }
    }
}
