namespace TradeOrgSistem.Services
{
    public class ProductPriceVolumeQueryResult
    {
        public int ProductId { get; set; }
        public int TotalVolume { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal AveragePrice { get; set; }
    }
}
