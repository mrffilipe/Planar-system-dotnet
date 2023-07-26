﻿using MongoDB.Bson;

namespace PlanarActivityWS.src.Domain;

public class Activity : BaseEntity
{
    public ObjectId UserId { get; private set; }
    public ActivityRelationship Relationship { get; private set; }
    public ActivityStatus Status { get; private set; }

    public Activity(
        ObjectId userId,
        ActivityRelationship relationship,
        ActivityStatus status
        )
    {
        UserId = userId;
        Relationship = relationship;
        Status = status;
    }

    public void ChangeStatus(ActivityStatus status)
    {
        if (status != Status) Status = status;
    }
}