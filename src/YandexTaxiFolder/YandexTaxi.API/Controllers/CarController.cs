using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexTaxi.Application.UseCases.Car.Commands;
using YandexTaxi.Application.UseCases.Car.Queries;
using YandexTaxi.Application.UseCases.Card.Commands;
using YandexTaxi.Application.UseCases.Card.Queries;

namespace YandexTaxi.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllCar()
    {
        var cards = await _mediator.Send(new GetCarCommand());
        return Ok(cards);
    }



    [HttpPost]

    public async ValueTask<bool> AddCar(PostCarCommand postCard)
    {
        var t = await _mediator.Send(postCard);
        return t;
    }
    [HttpPut]

    public async ValueTask<IActionResult> UpdateCar(PutCarCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }

    [HttpDelete]

    public async ValueTask<IActionResult> DeleteCar(DeleteCarCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }


}
