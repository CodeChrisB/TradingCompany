//@GeneratedCode
namespace TradingCompany.Logic.Controllers.Persistence.ItemMaster
{
    sealed partial class CustomerController : GenericPersistenceController<TradingCompany.Contracts.Persistence.ItemMaster.ICustomer, Entities.Persistence.ItemMaster.Customer>
    {
        static CustomerController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal CustomerController(DataContext.IContext context):base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal CustomerController(ControllerObject controller):base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
