using System.ComponentModel.DataAnnotations;

namespace InvoiceManagement.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public int ContactNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }


    }
}