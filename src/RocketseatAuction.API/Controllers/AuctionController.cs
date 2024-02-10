using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API;

namespace RocketseatAuction.API.Controllers;

[Route("[controller]")]
[ApiController]

public class AuctionController : ControllerBase
{
  [HttpGet]
  [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
  public IActionResult GetCurrentAuction()
  {
    var useCase = new GetCurrentAuctionUseCase();
    
    var result = useCase.Execute();
    return Ok(result);
  }
}