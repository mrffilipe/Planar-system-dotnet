using Microsoft.EntityFrameworkCore;

namespace PlanarSystemWS.src.Domain.AddressManagement;

public class Address
{
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string District { get; set; }
    public string Street { get; set; }
    public string Complement { get; set; }
}

//public readonly record struct Address(
//        string PostalCode,
//        string City,
//        string State,
//        string Country,
//        string District,
//        string Street,
//        string Complement
//    );