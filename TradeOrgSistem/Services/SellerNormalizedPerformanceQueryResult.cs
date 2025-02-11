using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Перечисление для выбора параметра нормализации.
    /// </summary>
    public enum NormalizationFactor
    {
        Area,       // Торговая площадь
        Halls,      // Число торговых залов
        Counters    // Число прилавков
    }

    /// <summary>
    /// Результат запроса нормализованной выработки продавца в торговой точке.
    /// </summary>
    public class SellerNormalizedPerformanceQueryResult
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public int RetailLocationId { get; set; }
        public string RetailLocationName { get; set; }
        /// <summary>
        /// Общий объём продаж продавца в заданном периоде.
        /// </summary>
        public int TotalSalesVolume { get; set; }
        /// <summary>
        /// Тип нормализации, выбранный для расчёта (торговая площадь, число залов или прилавков).
        /// </summary>
        public NormalizationFactor NormalizationType { get; set; }
        /// <summary>
        /// Значение нормализационного показателя, взятое из торговой точки.
        /// </summary>
        public decimal NormalizationValue { get; set; }
        /// <summary>
        /// Вычисленное отношение: TotalSalesVolume / NormalizationValue.
        /// </summary>
        public decimal Ratio { get; set; }
    }
}
