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
        public string ContactNumber { get; set; }



    }
}