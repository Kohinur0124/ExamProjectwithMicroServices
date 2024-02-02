using MediatR;
using Microsoft.AspNetCore.Mvc;
using Olx.Application.UseCases.Card.Commands;
using Olx.Application.UseCases.Card.Queries;
using Olx.Application.UseCases.Order.Commands;
using Olx.Application.UseCases.Order.Queries;

namespace Olx.API.Controllers;

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

    public async ValueTask<bool> AddOrder(PostOrderCommand postCard)
    {
        var t = await _mediator.Send(postCard);
        return t;
    }
    [HttpPut]

    public async ValueTask<IActionResult> UpdateOrder(PutOrderCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }

    [HttpDelete]

    public async ValueTask<IActionResult> DeleteOrder(DeleteOrderCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }


}
