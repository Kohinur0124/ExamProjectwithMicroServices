using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YandexTaxi.Application.UseCases.Card.Commands;
using YandexTaxi.Application.UseCases.Card.Queries;

namespace YandexTaxi.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CardsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CardsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllCards()
    {
        var cards = await _mediator.Send(new GetCardCommand());
        return Ok(cards);
    }



    [HttpPost]

    public async ValueTask<bool> AddCard(PostCardCommand postCard)
    {
        var t = await _mediator.Send(postCard);
        return t;
    }
    [HttpPut]

    public async ValueTask<IActionResult> UpdateCard(PutCardCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }

    [HttpDelete]

    public async ValueTask<IActionResult> DeleteCard(DeleteCardCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }


}
