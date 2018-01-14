namespace eSupport.Services.Client.API.Models
{
    public class Client
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool Active { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
    }
}