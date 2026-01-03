using Microsoft.AspNetCore.Mvc;

namespace ConvergenceCorpBlazor.Classes.API;

[ApiController]
[Route("/api")] // cc.net/api    ([controller] == /api?)
public class HomeController : ControllerBase
{
    [HttpGet(Name = "GetAPIHOME")] //does the Name even do anything? It's the operationId
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        return Ok("Convergence Corp API!\n" +
            "for Swagger Documentation on the API,  \n" +
            "goto https://convergencecorp.net/swagger\n\n" +
            "Still under development, so things will probably change.\n\n" +
            "endpoints: \n" +
            "/api/groups/{id?}\n");
    }
}
