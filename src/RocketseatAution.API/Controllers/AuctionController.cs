using Microsoft.AspNetCore.Mvc;
using RocketseatAution.API;

namespace RocketseatAuction.API.Controllers;

[Route("[controller]")]
[ApiController]

public class AuctionController : ControllerBase
{
  [HttpGet]
  public IActionResult GetCurrentAuction()
  {
    var useCase = new GetCurrentAuctionUseCase();
    
    var result = useCase.Execute();
    return Ok(result);
  }
}