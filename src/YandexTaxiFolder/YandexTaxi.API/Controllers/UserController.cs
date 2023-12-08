using MediatR;
using Microsoft.AspNetCore.Mvc;
using YandexTaxi.Application.UseCases.User.Commands;
using YandexTaxi.Application.UseCases.User.Queries;

namespace YandexTaxi.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllUser()
    {
        var cards = await _mediator.Send(new GetUserCommand());
        return Ok(cards);
    }



    [HttpPost]

    public async ValueTask<bool> AddUser(PostUserCommand postCard)
    {
        var t = await _mediator.Send(postCard);
        return t;
    }
    [HttpPut]

    public async ValueTask<IActionResult> UpdateUser(PutUserCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }

    [HttpDelete]

    public async ValueTask<IActionResult> DeleteUser(DeleteUserCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }


}
