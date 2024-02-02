using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexTaxi.Application.UseCases.Card.Commands;
using YandexTaxi.Application.UseCases.Card.Queries;
using YandexTaxi.Application.UseCases.Order.Commands;
using YandexTaxi.Application.UseCases.Order.Queries;

namespace YandexTaxi.API.Controllers;

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

    public async ValueTask<IActionResult> UpdateCrder(PutOrderCommand postUser)
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
