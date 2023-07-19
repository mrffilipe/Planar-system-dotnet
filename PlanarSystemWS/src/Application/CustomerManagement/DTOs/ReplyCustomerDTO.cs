﻿using PlanarSystemWS.src.Application.AddressManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class ReplyCustomerDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ReplyDocumentDTO Document { get; set; }
    public ReplyPhoneDTO Phone { get; set; }
    public ReplyAddressDTO Address { get; set; }
}