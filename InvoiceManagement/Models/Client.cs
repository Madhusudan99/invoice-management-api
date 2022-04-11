namespace InvoiceManagement.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string GSTNumber { get; set; }
        public string Address { get; set; }
        public string PAN { get; set; }


    }
}
