//@CodeCopy

namespace TradingCompany.Transfer.Models
{
    public partial class IdentityModel : TransferModel, Contracts.IIdentifiable
	{
		public int Id { get; set; }
	}
}
