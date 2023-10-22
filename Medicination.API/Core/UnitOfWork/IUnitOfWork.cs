namespace Medicination.API.Core.UnitOfWork
{
	public interface IUnitOfWork
	{
		void Commit();
		Task CommitAsync();
	}
}
