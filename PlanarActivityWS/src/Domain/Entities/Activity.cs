﻿using MongoDB.Bson;

namespace PlanarActivityWS.src.Domain;

public class Activity : BaseEntity
{
    public ActivityRelationship Relationship { get; private set; }
    public ActivityStatus Status { get; private set; }
    public string UserAccountId { get; private set; }

    public Activity(
        ActivityRelationship relationship,
        ActivityStatus status,
        string userAccountId
        )
    {
        Relationship = relationship;
        Status = status;
        UserAccountId = userAccountId;
    }

    public void ChangeStatus(ActivityStatus status)
    {
        if (status != Status) Status = status;
    }
}