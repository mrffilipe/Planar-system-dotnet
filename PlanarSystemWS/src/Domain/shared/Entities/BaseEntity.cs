﻿namespace PlanarSystemWS.src.Domain.Shared;

public abstract class BaseEntity : IEntity<Guid>
{
    public Guid Id { get; private set; }

    public DateTime CreatedOn { get; private set; }

    public DateTime UpdatedOn { get; private set; }
}
