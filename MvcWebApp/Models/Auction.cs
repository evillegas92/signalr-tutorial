namespace MvcWebApp.Models
{
    public class Auction
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        private readonly List<AuctionItem> auctionItems;

        public IEnumerable<AuctionItem> AuctionItems { get { return this.auctionItems; } }

        public Auction(int id, DateTime startDate, DateTime endDate, IEnumerable<AuctionItem> items)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            this.auctionItems = items != null ? items.ToList() : new List<AuctionItem>();
        }
    }
}
