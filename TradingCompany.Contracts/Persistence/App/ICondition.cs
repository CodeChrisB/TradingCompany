using CommonBase.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.Contracts.Persistence.ItemMaster
{
    public interface ICondition : IVersionable, ICopyable<ICondition>
    {
        int ProductId { get; set; }
        int CustomerId { get; set; }
        ConditionType type { get; set; }
        double Quantity { get; set; }
        decimal Value { get; set; }
    }
}

/*
 * Product Reference No Reference to Product
Customer Reference No Reference to Customer
ConditionType Enum No Type of condition
Quantity double No Sales or number of items
Value decimal No Discount or flat rate
*/