namespace TradingCompany.AspMvc.Models
{
	public class VersionModel : ModelObject, Contracts.IVersionable
	{
		public byte[] RowVersion { get; set; }
	}
}
