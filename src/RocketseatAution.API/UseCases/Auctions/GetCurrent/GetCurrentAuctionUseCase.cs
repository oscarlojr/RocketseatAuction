﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAution.API;

public class GetCurrentAuctionUseCase
{
  public Auction Execute()
  {
    var repository = new RocketseatAuctionDbContext();
    return repository
          .Auctions
          .Include(auction => auction.Items)
          .First();
  }
}
