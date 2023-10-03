using System.ComponentModel.DataAnnotations;

namespace PMS.API.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierNo { get; set; }
        public string SupplierName { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    } 
}
