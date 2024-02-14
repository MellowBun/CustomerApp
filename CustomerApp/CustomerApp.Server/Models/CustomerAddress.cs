using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerApp.Server.Models
{
    public class CustomerAddress
    {
        public int CustomerAddressID { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }

        // navigation property
        public Customer Customer { get; set; }
        public Address Address { get; set; }

    }
}
