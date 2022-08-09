using Serenity.ComponentModel;
using System;

namespace TestMenuProject.Administration.Forms
{
	[FormScript("Administration.Role")]
	[BasedOnRow(typeof(Entities.RoleRow), CheckNames = true)]
	public class RoleForm
	{
		public String RoleName { get; set; }
	}
}