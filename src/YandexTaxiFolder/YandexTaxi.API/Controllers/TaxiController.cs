using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexTaxi.Application.UseCases.Address.Commands;
using YandexTaxi.Application.UseCases.Address.Queries;
using YandexTaxi.Application.UseCases.Card.Commands;
using YandexTaxi.Application.UseCases.Card.Queries;
using YandexTaxi.Application.UseCases.Taxi.Commands;
using YandexTaxi.Application.UseCases.Taxi.Queries;

namespace YandexTaxi.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaxiController : ControllerBase
{
    private readonly IMediator _mediator;

    public TaxiController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllTaxi()
    {
        var cards = await _mediator.Send(new GetTaxiCommand());
        return Ok(cards);
    }



    [HttpPost]

    public async ValueTask<bool> AddTaxi(PostTaxiCommand postCard)
    {
        var t = await _mediator.Send(postCard);
        return t;
    }
    [HttpPut]

    public async ValueTask<IActionResult> UpdateTaxi(PutTaxiCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }

    [HttpDelete]

    public async ValueTask<IActionResult> DeleteTaxi(DeleteTaxiCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }


}
