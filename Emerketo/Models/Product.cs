namespace Emerketo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public int NumOfReviews { get; set; }
        public decimal Rating { get; set; }
        public decimal Price { get; set; }
        public bool IsPopular { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        public string ImgUrl { get; set; } = string.Empty;

    }
}
