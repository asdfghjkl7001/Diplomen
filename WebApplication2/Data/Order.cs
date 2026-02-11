namespace WebApplication1.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Clients { get; set; }
        public int ProductId { get; set; }
        public Prodoct Prodocts { get; set; }
        public string Staus { get; set; }
        public decimal PriceTotal { get; set; }
        //public ICollection<Prodoct> Prodocts { get; set; }
        //public ICollection<Service> Services { get; set; }
    }
}
