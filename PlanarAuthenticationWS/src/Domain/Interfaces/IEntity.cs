﻿namespace PlanarAuthenticationWS.src.Domain;

public interface IEntity
{
    string Id { get; }
    public string UserAccountId { get; }
    DateTime CreatedOn { get; }
    DateTime UpdatedOn { get; }
}