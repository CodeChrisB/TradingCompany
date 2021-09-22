//@GeneratedCode
namespace TradingCompany.Logic.DataContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    partial class TradingCompanyDbContext
    {
        protected DbSet<Entities.Persistence.App.Order> OrderSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.ItemMaster.Condition> ConditionSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.ItemMaster.Customer> CustomerSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.ItemMaster.Product> ProductSet
        {
            get;
            set;
        }
        partial void GetDbSet<I, E>(ref DbSet<E> dbSet) where E : class
        {
            if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.App.IOrder))
            {
                dbSet = OrderSet as DbSet<E>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICondition))
            {
                dbSet = ConditionSet as DbSet<E>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.ICustomer))
            {
                dbSet = CustomerSet as DbSet<E>;
            }
            else if (typeof(I) == typeof(TradingCompany.Contracts.Persistence.ItemMaster.IProduct))
            {
                dbSet = ProductSet as DbSet<E>;
            }
        }
        static partial void DoModelCreating(ModelBuilder modelBuilder)
        {
            var orderBuilder = modelBuilder.Entity<Entities.Persistence.App.Order>();
            orderBuilder.ToTable("Order", "App").HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.App.Order>().Property(p => p.RowVersion).IsRowVersion();
            ConfigureEntityType(orderBuilder);
            var conditionBuilder = modelBuilder.Entity<Entities.Persistence.ItemMaster.Condition>();
            conditionBuilder.ToTable("Condition", "ItemMaster").HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.ItemMaster.Condition>().Property(p => p.RowVersion).IsRowVersion();
            ConfigureEntityType(conditionBuilder);
            var customerBuilder = modelBuilder.Entity<Entities.Persistence.ItemMaster.Customer>();
            customerBuilder.ToTable("Customer", "ItemMaster").HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.ItemMaster.Customer>().Property(p => p.RowVersion).IsRowVersion();
            customerBuilder.HasIndex(c => c.Number).IsUnique();
            customerBuilder.Property(p => p.Number).IsRequired().HasMaxLength(8);
            customerBuilder.Property(p => p.Name).IsRequired().HasMaxLength(256);
            ConfigureEntityType(customerBuilder);
            var productBuilder = modelBuilder.Entity<Entities.Persistence.ItemMaster.Product>();
            productBuilder.ToTable("Product", "ItemMaster").HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.ItemMaster.Product>().Property(p => p.RowVersion).IsRowVersion();
            productBuilder.HasIndex(c => c.Number).IsUnique();
            productBuilder.Property(p => p.Number).IsRequired().HasMaxLength(8);
            productBuilder.Property(p => p.Name).IsRequired().HasMaxLength(256);
            ConfigureEntityType(productBuilder);
        }
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Order> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.ItemMaster.Condition> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.ItemMaster.Customer> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.ItemMaster.Product> entityTypeBuilder);
    }
}
