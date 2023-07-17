namespace PlanarSystemWS.src.Domain.CustomerManagement;

public class Phone
{
    public string CountryCode { get; set; } 
    public string DDD { get; set; }
    public string Number { get; set; }
}

//public readonly record struct Phone(
//        string CountryCode,
//        string DDD,
//        string Number
//    );