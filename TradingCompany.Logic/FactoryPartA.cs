//@GeneratedCode
namespace TradingCompany.Logic
{
    public static partial class Factory
    {
        static partial void CreateController<I>(ref Contracts.Client.IControllerAccess<I> controller) where I : Contracts.IIdentifiable
        {
            if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.App.IOrder))
            {
                controller = new Controllers.Persistence.App.OrderController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICondition))
            {
                controller = new Controllers.Persistence.ItemMaster.ConditionController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer))
            {
                controller = new Controllers.Persistence.ItemMaster.CustomerController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.IProduct))
            {
                controller = new Controllers.Persistence.ItemMaster.ProductController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
            }
            else
            {
                throw new Logic.Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidControllerType);
            }
        }
        static partial void CreateController<I>(object sharedController, ref Contracts.Client.IControllerAccess<I> controller) where I : Contracts.IIdentifiable
        {
            if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.App.IOrder))
            {
                controller = new Controllers.Persistence.App.OrderController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICondition))
            {
                controller = new Controllers.Persistence.ItemMaster.ConditionController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer))
            {
                controller = new Controllers.Persistence.ItemMaster.CustomerController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.IProduct))
            {
                controller = new Controllers.Persistence.ItemMaster.ProductController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
            }
            else
            {
                throw new Logic.Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidControllerType);
            }
        }
    }
}
