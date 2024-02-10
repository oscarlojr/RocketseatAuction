﻿using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Filters;

namespace RocketseatAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RocketseatAuctionBaseController
{
  [HttpPost]
  [Route("{itemId}")]
  
  public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
  {
    return Created();
  }
}
