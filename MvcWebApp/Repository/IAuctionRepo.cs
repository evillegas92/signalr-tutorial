using MvcWebApp.Models;

namespace MvcWebApp.Repository
{
    public interface IAuctionRepo
    {
        IEnumerable<Auction> GetAllAuctions();

        Auction? GetAuction(int id);

        void BidOnItem(int auctionItemId, decimal bidAmount);
    }
}
