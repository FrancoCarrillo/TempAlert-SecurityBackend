﻿namespace Core.Entities;

public class UserRols
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid RolId { get; set; }
    public Rol Rol { get; set; }
}

