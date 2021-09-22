using CommonBase.Attributes;

namespace TradingCompany.Contracts.Persistence.ItemMaster
{
    public interface ICustomer : IVersionable, ICopyable<ICustomer>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 8, IsUnique = true)]
        string Number { get; set; }
        [ContractPropertyInfo(Required = true,MaxLength = 256)]
        string Name { get; set; }
    }
}
