using System.ComponentModel.DataAnnotations;

namespace InvoiceManagement.Models
{
    public class InvoiceDetail
    {
        [Key]
        public string InvoiceNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        [Required]
        public int ClientId { get; set; }

        [Required]
        public int CompanyId { get; set; }

    }
}
