using System.ComponentModel.DataAnnotations;

namespace InvoiceManagement.Models
{
    public class InvoiceDetail
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public string ProductName { get; set; }
        [Required]
        public string InvoiceNumber { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public float Tax { get; set; }
        [Required]
        public float Amount { get; set; }

    }
}
