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
        DateTime CreatedOn { get; set; }
        int Count { get; set; }
        double PriceNet { get; set; }
        double Discount { get; set; }
    }
}

//Product Reference No Reference to Product
//Customer Reference No Reference to Customer
//CreatedOn DateTime No Creation date of order.
//Count int No Numbers of Products
//PriceNet decimal No Total price net
//Discount decimal No Discount
//
