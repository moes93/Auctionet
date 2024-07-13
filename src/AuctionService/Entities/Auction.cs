using System;

namespace AuctionService.Entities
{
    public class Auction
    {
        public Guid Id { get; set; }
        public int ReservePrice { get; set; } = 0;
        public string Seller { get; set; }
        public string Winner { get; set; }
        public int? SoldAmount { get; set; }
        public int? CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Fixed typo: CreateAt to CreatedAt
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Fixed typo: UpdatedAt to UpdatedAt
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; }
        public Item Item { get; set; }
    }
}
