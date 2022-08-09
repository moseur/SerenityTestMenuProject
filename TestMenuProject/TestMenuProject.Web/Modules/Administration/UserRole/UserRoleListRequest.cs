using Serenity.Services;

namespace TestMenuProject.Administration
{
	public class UserRoleListRequest : ServiceRequest
	{
		public int? UserID { get; set; }
	}
}