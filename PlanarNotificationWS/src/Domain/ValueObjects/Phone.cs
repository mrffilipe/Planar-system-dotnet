namespace PlanarNotificationWS.src.Domain;

public record Phone(
        string CountryCode,
        string DDD,
        string Number
    );