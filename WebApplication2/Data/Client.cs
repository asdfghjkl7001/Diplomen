using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data
{
    public class Client : IdentityUser 
    {
        public string FullName { get; set; }
        //public int Id { get; set; }
        // public string UserName { get; set; }
        // public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
