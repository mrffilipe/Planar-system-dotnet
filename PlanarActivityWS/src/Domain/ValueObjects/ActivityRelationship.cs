namespace PlanarActivityWS.src.Domain;

public record ActivityRelationship(
        ActivityType Type,
        string RelationshipId
    );