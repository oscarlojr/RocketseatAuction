using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.API.Controllers;

[Route("[controller]")]
[ApiController]

public class AuctionController : ControllerBase
{
  [HttpGet]
  public IActionResult GetActionResult()
  {
    return NotFound("Oscar");
  }

  [HttpGet("test")]
  public IActionResult GetTest()
  {
    return Ok("Oscar");
  }
}