namespace MvcSourceCodeLearning.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
    }
}