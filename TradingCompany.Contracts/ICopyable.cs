//@CodeCopy

namespace TradingCompany.Contracts
{
	public partial interface ICopyable<T>
	{
		void CopyProperties(T other);
	}
}
