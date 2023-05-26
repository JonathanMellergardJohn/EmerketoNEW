using Emerketo.Areas.Identity.Data;

namespace Emerketo.ViewModels
{
    public class AddUserViewModel
    {
        public EmerketoUser User { get; set; } = new EmerketoUser();
        public string UserRole { get; set; } = string.Empty;
        public List<string> RolesInDb { get; set; } = new List<string>();
    }
}
