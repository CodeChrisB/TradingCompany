using CommonBase.Attributes;

namespace TradingCompany.Contracts.Persistence.ItemMaster
{
    public interface IProduct : IVersionable, ICopyable<IProduct>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 8, IsUnique = true)]
        string Number { get; set; }
        [ContractPropertyInfo(MaxLength = 256, Required = true)]
        string Name { get; set; }

        double Price { get; set; }
    }
}
