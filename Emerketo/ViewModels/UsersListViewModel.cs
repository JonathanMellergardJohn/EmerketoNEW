using Emerketo.Areas.Identity.Data;

namespace Emerketo.ViewModels
{
	public class UsersListViewModel
	{
		public List<ProfileViewModel> Users = new List<ProfileViewModel>();
		public List<string> Roles = new List<string>();
	}
}
