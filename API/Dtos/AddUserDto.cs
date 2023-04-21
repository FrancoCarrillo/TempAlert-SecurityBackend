﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class AddUserDto
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Names { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string MotherLastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
}
