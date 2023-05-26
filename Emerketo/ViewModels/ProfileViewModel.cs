namespace Emerketo.ViewModels
{
    public class ProfileViewModel
    {
        public string UserName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string StreetAdress { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public List<string> RolesInDb { get; set; } = new List<string>();
    }
}
