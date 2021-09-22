//@GeneratedCode
namespace TradingCompany.Logic.Entities.Persistence.ItemMaster
{
    partial class Condition
    {
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("ProductId")]
        public TradingCompany.Logic.Entities.Persistence.ItemMaster.Product Product
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CustomerId")]
        public TradingCompany.Logic.Entities.Persistence.ItemMaster.Customer Customer
        {
            get;
            set;
        }
    }
}
