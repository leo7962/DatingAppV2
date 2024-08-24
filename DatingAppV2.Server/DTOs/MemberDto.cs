﻿using System.ComponentModel.DataAnnotations;

namespace DatingAppV2.Server.DTOs;

public class MemberDto
{
    [Key] public int Id { get; set; }
    [Required] public string? UserName { get; set; }
    public int Age { get; set; }
    public string? PhotoUrl { get; set; }
    public string? KnownAs { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastActive { get; set; }
    public string? Gender { get; set; }
    public string? Introduction { get; set; }
    public string? Interests { get; set; }
    public string? LookingFor { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public List<PhotoDto>? Photos { get; set; }
}