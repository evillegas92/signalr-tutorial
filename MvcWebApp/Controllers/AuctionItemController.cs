using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Repository;

namespace MvcWebApp.Controllers
{
    public class AuctionItemController : Controller
    {
        private readonly IAuctionRepo auctionRepo;

        public AuctionItemController(IAuctionRepo auctionRepo)
        {
            this.auctionRepo = auctionRepo;
        }

        [Produces("application/json")]
        [HttpPost]
        public IActionResult Bid([FromBody] NewBid newBid)
        {
            this.auctionRepo.BidOnItem(newBid.AuctionItemId, newBid.BidAmount);
            return Ok();
        }
    }

    public class NewBid
    {
        public int AuctionItemId { get; set; }
        public decimal BidAmount { get; set; }
    }
}
