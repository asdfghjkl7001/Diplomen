namespace WebApplication1.Data
{
    public class Prodoct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal PriceTotal { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Service> services { get; set; }
    }
}
