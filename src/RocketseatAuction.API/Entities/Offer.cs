namespace RocketseatAuction.API.Entities;

public class Offer
{
  public int id { get; set; }
  public DateTime CreatedOn { get; set; }
  public decimal Price { get; set; }
  public int itemId { get; set; }
  public int UserId { get; set; }
}
