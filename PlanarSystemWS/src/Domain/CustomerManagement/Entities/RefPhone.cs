﻿using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.CustomerManagement;

public class RefPhone : BaseEntity
{
    public bool IsWhatsapp { get; private set; }
    public Phone Phone { get; private set; }

    public RefPhone(bool isWhatsapp, Phone phone)
    {
        IsWhatsapp = isWhatsapp;
        Phone = phone;
    }

    public void SetIsWhatsapp()
    {
        if (!IsWhatsapp) IsWhatsapp = true;
    }

    public void SetIsNotWhatsapp()
    {
        if (IsWhatsapp) IsWhatsapp = false;
    }

    public void UpdatePhone(Phone phone)
    {
        if (phone != Phone) Phone = phone;
    }
}