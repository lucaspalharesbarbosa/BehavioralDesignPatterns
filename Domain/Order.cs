using Domain.Enums;

namespace Domain {
    public class Order {
        public ShippingOptions ShippingOption { get; set; }
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }
}
