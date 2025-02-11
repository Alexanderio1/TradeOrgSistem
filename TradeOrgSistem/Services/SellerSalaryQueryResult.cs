using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса данных о заработной плате продавцов.
    /// </summary>
    public class SellerSalaryQueryResult
    {
        /// <summary>
        /// Список деталей по каждому продавцу.
        /// </summary>
        public List<SellerSalaryDetail> SellerSalaries { get; set; }

        /// <summary>
        /// Общее число продавцов, удовлетворяющих условию фильтрации.
        /// </summary>
        public int TotalCount { get; set; }
    }

    /// <summary>
    /// Детали по заработной плате продавца, включающие информацию о продавце и его торговой точке.
    /// </summary>
    public class SellerSalaryDetail
    {
        /// <summary>
        /// ID продавца.
        /// </summary>
        public int SellerId { get; set; }

        /// <summary>
        /// Имя продавца.
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// Зарплата продавца.
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// ID торговой точки, где работает продавец.
        /// </summary>
        public int RetailLocationId { get; set; }

        /// <summary>
        /// Название торговой точки.
        /// </summary>
        public string RetailLocationName { get; set; }
    }
}
