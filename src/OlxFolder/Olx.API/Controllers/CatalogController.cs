using MediatR;
using Microsoft.AspNetCore.Mvc;
using Olx.Application.UseCases.Card.Commands;
using Olx.Application.UseCases.Card.Queries;
using Olx.Application.UseCases.Catalog.Commands;
using Olx.Application.UseCases.Catalog.Queries;
using Olx.Application.UseCases.Product.Commands;
using Olx.Application.UseCases.Product.Queries;

namespace Olx.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatalogController : ControllerBase
{
    private readonly IMediator _mediator;

    public CatalogController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllCatalog()
    {
        var cards = await _mediator.Send(new GetCatalogCommand());
        return Ok(cards);
    }



    [HttpPost]

    public async ValueTask<bool> AddCatalog(PostCatalogCommand postCard)
    {
        var t = await _mediator.Send(postCard);
        return t;
    }
    [HttpPut]

    public async ValueTask<IActionResult> UpdateCatalog(PutCatalogCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }

    [HttpDelete]

    public async ValueTask<IActionResult> DeleteCatalog(DeleteCatalogCommand postUser)
    {
        var t = await _mediator.Send(postUser);
        return Ok(t);
    }


}
