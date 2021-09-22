//@CodeCopy
//MdStart
using TradingCompany.Contracts;

namespace TradingCompany.Logic.Entities
{
    internal abstract partial class IdentityEntity : EntityObject, IIdentifiable
	{
		public int Id { get; set; }
    }
}
//MdEnd
