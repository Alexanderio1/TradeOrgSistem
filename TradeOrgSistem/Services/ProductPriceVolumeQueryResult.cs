namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса сведений об объёме продаж и ценах на указанный товар.
    /// </summary>
    public class ProductPriceVolumeQueryResult
    {
        /// <summary>
        /// Идентификатор товара.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Общий объём продаж товара.
        /// </summary>
        public int TotalVolume { get; set; }

        /// <summary>
        /// Минимальная цена продажи товара.
        /// </summary>
        public decimal MinPrice { get; set; }

        /// <summary>
        /// Максимальная цена продажи товара.
        /// </summary>
        public decimal MaxPrice { get; set; }

        /// <summary>
        /// Средняя цена продажи товара.
        /// </summary>
        public decimal AveragePrice { get; set; }
    }
}
