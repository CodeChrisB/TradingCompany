//@GeneratedCode
namespace TradingCompany.Transfer.Models.Persistence.ItemMaster
{
    using System;
    public partial class Condition : TradingCompany.Contracts.Persistence.ItemMaster.ICondition
    {
        static Condition()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Condition()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.Int32 ProductId
        {
            get;
            set;
        }
        public System.Int32 CustomerId
        {
            get;
            set;
        }
        public System.DateTime CreatedOn
        {
            get;
            set;
        }
        public System.Int32 Count
        {
            get;
            set;
        }
        public System.Double PriceNet
        {
            get;
            set;
        }
        public System.Double Discount
        {
            get;
            set;
        }
        public void CopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.ICondition other)
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
                ProductId = other.ProductId;
                CustomerId = other.CustomerId;
                CreatedOn = other.CreatedOn;
                Count = other.Count;
                PriceNet = other.PriceNet;
                Discount = other.Discount;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.ICondition other, ref bool handled);
        partial void AfterCopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.ICondition other);
        public static Persistence.ItemMaster.Condition Create()
        {
            BeforeCreate();
            var result = new Persistence.ItemMaster.Condition();
            AfterCreate(result);
            return result;
        }
        public static Persistence.ItemMaster.Condition Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.ItemMaster.Condition();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.ItemMaster.Condition Create(TradingCompany.Contracts.Persistence.ItemMaster.ICondition other)
        {
            BeforeCreate(other);
            var result = new Persistence.ItemMaster.Condition();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.ItemMaster.Condition instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.ItemMaster.Condition instance, object other);
        static partial void BeforeCreate(TradingCompany.Contracts.Persistence.ItemMaster.ICondition other);
        static partial void AfterCreate(Persistence.ItemMaster.Condition instance, TradingCompany.Contracts.Persistence.ItemMaster.ICondition other);
    }
}
