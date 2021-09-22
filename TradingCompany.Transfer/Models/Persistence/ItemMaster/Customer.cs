//@GeneratedCode
namespace TradingCompany.Transfer.Models.Persistence.ItemMaster
{
    using System;
    public partial class Customer : TradingCompany.Contracts.Persistence.ItemMaster.ICustomer
    {
        static Customer()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Customer()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.String Number
        {
            get;
            set;
        }
        public System.String Name
        {
            get;
            set;
        }
        public void CopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer other)
        {
            if (other == null)
            {
                throw new System.ArgumentNullException(nameof(other));
            }
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Id = other.Id;
                RowVersion = other.RowVersion;
                Number = other.Number;
                Name = other.Name;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer other, ref bool handled);
        partial void AfterCopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer other);
        public static Persistence.ItemMaster.Customer Create()
        {
            BeforeCreate();
            var result = new Persistence.ItemMaster.Customer();
            AfterCreate(result);
            return result;
        }
        public static Persistence.ItemMaster.Customer Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.ItemMaster.Customer();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.ItemMaster.Customer Create(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer other)
        {
            BeforeCreate(other);
            var result = new Persistence.ItemMaster.Customer();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.ItemMaster.Customer instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.ItemMaster.Customer instance, object other);
        static partial void BeforeCreate(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer other);
        static partial void AfterCreate(Persistence.ItemMaster.Customer instance, TradingCompany.Contracts.Persistence.ItemMaster.ICustomer other);
    }
}
