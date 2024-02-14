using System.ComponentModel.DataAnnotations;

namespace CustomerApp.Server.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }

        // navigation property
        public ICollection<Phone> PhoneNumbers { get; set; }

        // Email? - 0-n
        public ICollection<Email> Emails { get; set; }

        // Address?
        public ICollection<CustomerAddress> Addresses { get; set; }
    }
}
