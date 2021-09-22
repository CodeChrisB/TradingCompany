//@GeneratedCode
namespace TradingCompany.Adapters
{
    public static partial class Factory
    {
        public static Contracts.Client.IAdapterAccess<I> Create<I>()
        {
            Contracts.Client.IAdapterAccess<I> result = null;
            if (Adapter == AdapterType.Controller)
            {
                if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.App.IOrder))
                {
                    result = new Controller.GenericControllerAdapter<TradingCompany.Contracts.Persistence.App.IOrder>() as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICondition))
                {
                    result = new Controller.GenericControllerAdapter<TradingCompany.Contracts.Persistence.ItemMaster.ICondition>() as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer))
                {
                    result = new Controller.GenericControllerAdapter<TradingCompany.Contracts.Persistence.ItemMaster.ICustomer>() as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.IProduct))
                {
                    result = new Controller.GenericControllerAdapter<TradingCompany.Contracts.Persistence.ItemMaster.IProduct>() as Contracts.Client.IAdapterAccess<I>;
                }
            }
            else if (Adapter == AdapterType.Service)
            {
                if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.App.IOrder))
                {
                    result = new Service.GenericServiceAdapter<TradingCompany.Contracts.Persistence.App.IOrder, Transfer.Models.Persistence.App.Order>(BaseUri, "Orders") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICondition))
                {
                    result = new Service.GenericServiceAdapter<TradingCompany.Contracts.Persistence.ItemMaster.ICondition, Transfer.Models.Persistence.ItemMaster.Condition>(BaseUri, "Conditions") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer))
                {
                    result = new Service.GenericServiceAdapter<TradingCompany.Contracts.Persistence.ItemMaster.ICustomer, Transfer.Models.Persistence.ItemMaster.Customer>(BaseUri, "Customers") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.IProduct))
                {
                    result = new Service.GenericServiceAdapter<TradingCompany.Contracts.Persistence.ItemMaster.IProduct, Transfer.Models.Persistence.ItemMaster.Product>(BaseUri, "Products") as Contracts.Client.IAdapterAccess<I>;
                }
            }
            return result;
        }
        public static Contracts.Client.IAdapterAccess<I> Create<I>(string sessionToken)
        {
            Contracts.Client.IAdapterAccess<I> result = null;
            if (Adapter == AdapterType.Controller)
            {
                if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.App.IOrder))
                {
                    result = new Controller.GenericControllerAdapter<TradingCompany.Contracts.Persistence.App.IOrder>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICondition))
                {
                    result = new Controller.GenericControllerAdapter<TradingCompany.Contracts.Persistence.ItemMaster.ICondition>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer))
                {
                    result = new Controller.GenericControllerAdapter<TradingCompany.Contracts.Persistence.ItemMaster.ICustomer>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.IProduct))
                {
                    result = new Controller.GenericControllerAdapter<TradingCompany.Contracts.Persistence.ItemMaster.IProduct>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
                }
            }
            else if (Adapter == AdapterType.Service)
            {
                if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.App.IOrder))
                {
                    result = new Service.GenericServiceAdapter<TradingCompany.Contracts.Persistence.App.IOrder, Transfer.Models.Persistence.App.Order>(sessionToken, BaseUri, "Orders") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICondition))
                {
                    result = new Service.GenericServiceAdapter<TradingCompany.Contracts.Persistence.ItemMaster.ICondition, Transfer.Models.Persistence.ItemMaster.Condition>(sessionToken, BaseUri, "Conditions") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer))
                {
                    result = new Service.GenericServiceAdapter<TradingCompany.Contracts.Persistence.ItemMaster.ICustomer, Transfer.Models.Persistence.ItemMaster.Customer>(sessionToken, BaseUri, "Customers") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.IProduct))
                {
                    result = new Service.GenericServiceAdapter<TradingCompany.Contracts.Persistence.ItemMaster.IProduct, Transfer.Models.Persistence.ItemMaster.Product>(sessionToken, BaseUri, "Products") as Contracts.Client.IAdapterAccess<I>;
                }
            }
            return result;
        }
    }
}
