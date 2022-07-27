using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace NaviConnectWebApi.Models;

public class UserRegisterRequest
{
    [Required] public string City { get; set; } = null;
    [Required] 
    public string Username { get; set; } = string.Empty;

    [Required] public string FirstName { get; set; } = null;

    [Required]
    public string Lastname { get; set; } = null;

    public string SurName { get; set; } = null;
    
    // public string Phone { get; set; }
    
    [Required]
   
    [DataType(DataType.Upload)]
    public IFormFile File { get; set; } = null;
    
    [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters, dude!")]
    public string Password { get; set; } = string.Empty;
    [Required, Compare("Password")]
    public string ConfirmPassword { get; set; } = string.Empty; 
}