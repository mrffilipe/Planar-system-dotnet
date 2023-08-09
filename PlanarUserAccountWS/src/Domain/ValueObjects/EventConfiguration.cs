namespace PlanarUserAccountWS.src.Domain;

public record EventConfiguration(
    string Queue,
    string Exchange,
    string RoutingKey
    );