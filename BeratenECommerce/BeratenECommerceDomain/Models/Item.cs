namespace BeratenECommerceDomain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string ImageLink { get; set; }
        public string Description { get; set; }
        public bool CartFlag { get; set; }

    }
}
