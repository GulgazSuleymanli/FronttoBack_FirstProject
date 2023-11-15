namespace TravelAgency_FronttoBack.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public int Duration { get; set; }
        public string ImageUrl { get; set; }
    }
}
