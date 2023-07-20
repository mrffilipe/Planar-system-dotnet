namespace PlanarNotificationWS.src.Domain;

public record NotificationRelationship(
        NotificationRelationshipType Type,
        Guid RelationshipId
    );