using System.ComponentModel.DataAnnotations;

namespace InvoiceManagement.Models
{
    public class InvoiceItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public string InvoiceNumber { get; set; }
        [Required]
        public int Quantity { get; set; }

        [Required]
        public float Tax { get; set; }
        [Required]
        public float Amount { get; set; }
    }
}