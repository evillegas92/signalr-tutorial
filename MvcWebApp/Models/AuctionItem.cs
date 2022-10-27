namespace MvcWebApp.Models;

public class AuctionItem {
    public int Id { get; set; }

    public string? ItemName { get; set; }

    public decimal CurrentBid { get; set; }
}