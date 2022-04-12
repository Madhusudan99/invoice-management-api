using System.ComponentModel.DataAnnotations;

namespace InvoiceManagement.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public double productPrice { get; set; }
    }
}
