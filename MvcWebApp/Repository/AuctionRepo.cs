using MvcWebApp.Models;

namespace MvcWebApp.Repository
{
    public class AuctionRepo : IAuctionRepo
    {
        private readonly List<Auction> auctions = new();

        public AuctionRepo()
        {
            InitializeAuctionsFromMemory();
        }

        public void BidOnItem(int auctionItemId, decimal bidAmount)
        {
            AuctionItem? item = FindById(auctionItemId);
            if (item == null)
                return;
            item.CurrentBid = bidAmount;            
        }

        public IEnumerable<Auction> GetAllAuctions()
        {
            return this.auctions;
        }

        public Auction? GetAuction(int id)
        {
            return this.auctions?.FirstOrDefault(auction => auction.Id == id);
        }

        private void InitializeAuctionsFromMemory()
        {
            var auction = new Auction(1, DateTime.UtcNow, DateTime.UtcNow.AddDays(10), new List<AuctionItem>
            {
                new AuctionItem
                {
                    Id = 1,
                    ItemName = "Refrigerator",
                    CurrentBid = 0.0m
                },
                new AuctionItem
                {
                    Id = 2,
                    ItemName = "Headphones",
                    CurrentBid = 23.0m
                },
                new AuctionItem
                {
                    Id = 3,
                    ItemName = "TV",
                    CurrentBid = 200.5m
                }
            });
            this.auctions.Add(auction);
        }

        private AuctionItem? FindById(int auctionItemId)
        {
            foreach (Auction auction in this.auctions)
            {
                foreach (AuctionItem auctionItem in auction.AuctionItems)
                {
                    if (auctionItem.Id == auctionItemId)
                        return auctionItem;
                }
            }
            return null;
        }
    }
}
