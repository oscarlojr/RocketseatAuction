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
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  public IActionResult GetCurrentAuction()
  {
    var useCase = new GetCurrentAuctionUseCase();
    
    var result = useCase.Execute();

    if(result is null) 
      return NoContent();
    return Ok(result);
  }
}