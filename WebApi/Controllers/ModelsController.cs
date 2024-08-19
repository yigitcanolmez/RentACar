using Application.Features.Models.Queries.GetList;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelsController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
    {
        GetListModelQuery getListModelQuery = new GetListModelQuery() { PageRequest = pageRequest };
        return Ok(await Mediator.Send(getListModelQuery));
    }
}
