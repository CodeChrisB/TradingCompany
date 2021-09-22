using System;

namespace TradingCompany.Contracts.Persistence.App
{ 
    public interface IOrder : IVersionable, ICopyable<IOrder>
    {
        int ProductId { get; set; }
        int CustomerId { get; set; }
        DateTime CreatedOn { get; }
        int Count { get; set; }
        decimal PriceNet { get; }
        decimal Discount { get; }
    }
}