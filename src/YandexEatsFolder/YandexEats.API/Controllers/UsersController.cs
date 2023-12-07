using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Application.UseCases.User.Commands;
using YandexEats.Application.UseCases.User.Queries;
namespace YandexEats.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]

    public async ValueTask<IActionResult> GetAllUsers()
    {
        var users = await _mediator.Send(new GetUserCommand());
        return Ok(users);
    }

    [HttpPost]

    public async ValueTask<IActionResult> CreateUser(PostUserCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
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
