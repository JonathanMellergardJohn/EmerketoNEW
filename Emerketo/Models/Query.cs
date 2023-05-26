namespace Emerketo.Models
{
	public class Query
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Phone { get; set; } = null!;
		public string Company { get; set; } = string.Empty!;
		public string Message { get; set; } = null!;
	}
}
