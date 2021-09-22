//@CodeCopy

using TradingCompany.Contracts;

namespace TradingCompany.Logic.Entities
{
	internal abstract partial class VersionEntity : IdentityEntity, IVersionable
	{
		public byte[] RowVersion { get; set; }
	}
}
