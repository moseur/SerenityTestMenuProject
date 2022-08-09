using Serenity.Services;

namespace TestMenuProject.Administration
{
	public class TranslationListRequest : ListRequest
	{
		public string SourceLanguageID { get; set; }
		public string TargetLanguageID { get; set; }
	}
}