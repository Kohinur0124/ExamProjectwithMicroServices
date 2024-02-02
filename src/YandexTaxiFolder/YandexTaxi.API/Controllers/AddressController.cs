using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexTaxi.Application.UseCases.Address.Commands;
using YandexTaxi.Application.UseCases.Address.Queries;
using YandexTaxi.Application.UseCases.Card.Commands;
using YandexTaxi.Application.UseCases.Card.Queries;

namespace YandexTaxi.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly IMediator _mediator;

    public AddressController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllAddress()
    {
        var cards = await _mediator.Send(new GetAddressCommand());
        return Ok(cards);
    }



    [HttpPost]

    public async ValueTask<bool> AddAddress(PostAddressCommand postCard)
    {
        var t = await _mediator.Send(postCard);
        return t;
    }
    [HttpPut]

    public async ValueTask<IActionResult> UpdateAddress(PutAddressCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }

    [HttpDelete]

    public async ValueTask<IActionResult> DeleteAddress(DeleteAddressCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }


}
