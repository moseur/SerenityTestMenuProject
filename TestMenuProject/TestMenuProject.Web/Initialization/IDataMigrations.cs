
namespace TestMenuProject
{
	public interface IDataMigrations
	{
		bool SkippedMigrations { get; }

		void Initialize();
	}
}