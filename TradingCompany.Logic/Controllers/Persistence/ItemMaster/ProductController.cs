//@GeneratedCode
namespace TradingCompany.Logic.Controllers.Persistence.ItemMaster
{
    sealed partial class ProductController : GenericPersistenceController<TradingCompany.Contracts.Persistence.ItemMaster.IProduct, Entities.Persistence.ItemMaster.Product>
    {
        static ProductController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal ProductController(DataContext.IContext context):base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal ProductController(ControllerObject controller):base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
