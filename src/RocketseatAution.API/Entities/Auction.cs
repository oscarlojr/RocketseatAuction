﻿namespace RocketseatAution.API;

public class Auction
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public DateTime Starts { get; set; }
  public DateTime Ends { get; set; }

}
