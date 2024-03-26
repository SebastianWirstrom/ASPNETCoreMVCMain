﻿namespace Infrastructure.Entities;

public class AddressEntity
{
    public string Id { get; set; } = null!;
    public string AddressLine_1 { get; set; } = null!;
    public string? AddressLine_2 { get; set; }
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

    public string? UserId { get; set; } 
    public UserEntity User { get; set; } = null!;
}
