//@GeneratedCode
namespace TradingCompany.Logic.Entities.Persistence.ItemMaster
{
    using System;
    partial class Product : TradingCompany.Contracts.Persistence.ItemMaster.IProduct
    {
        static Product()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Product()
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
        public System.Double Price
        {
            get;
            set;
        }
        public void CopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.IProduct other)
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
                Price = other.Price;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.IProduct other, ref bool handled);
        partial void AfterCopyProperties(TradingCompany.Contracts.Persistence.ItemMaster.IProduct other);
        public override bool Equals(object obj)
        {
            if (obj is not TradingCompany.Contracts.Persistence.ItemMaster.IProduct instance)
            {
                return false;
            }
            return base.Equals(instance) && Equals(instance);
        }
        protected bool Equals(TradingCompany.Contracts.Persistence.ItemMaster.IProduct other)
        {
            if (other == null)
            {
                return false;
            }
            return IsEqualsWith(Number, other.Number) && IsEqualsWith(Name, other.Name) && Price == other.Price;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Number, Name, Price);
        }
        public static Persistence.ItemMaster.Product Create()
        {
            BeforeCreate();
            var result = new Persistence.ItemMaster.Product();
            AfterCreate(result);
            return result;
        }
        public static Persistence.ItemMaster.Product Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.ItemMaster.Product();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.ItemMaster.Product Create(TradingCompany.Contracts.Persistence.ItemMaster.IProduct other)
        {
            BeforeCreate(other);
            var result = new Persistence.ItemMaster.Product();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.ItemMaster.Product instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.ItemMaster.Product instance, object other);
        static partial void BeforeCreate(TradingCompany.Contracts.Persistence.ItemMaster.IProduct other);
        static partial void AfterCreate(Persistence.ItemMaster.Product instance, TradingCompany.Contracts.Persistence.ItemMaster.IProduct other);
    }
}
