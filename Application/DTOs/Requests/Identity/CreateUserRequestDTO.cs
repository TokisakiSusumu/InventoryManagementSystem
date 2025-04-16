﻿using System.ComponentModel.DataAnnotations;

namespace IMS.Application.DTOs.Requests.Identity;
public class CreateUserRequestDTO : LoginUserRequestDTO
{
    [Required]
    public string Name { get; set; }
    [Required]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; }
    [Required]
    public string Policy { get; set; }
}
