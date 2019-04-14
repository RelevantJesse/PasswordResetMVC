using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PasswordResetMVC.Models
{
    public class LoginRequest
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime RequestedDate { get; set; }
        public bool IsCompletedReset { get; set; }
        public bool IsTimedOut { get; set; }
        public bool IsValidUser { get; set; }
        public Guid? AccessToken { get; set; }
    }

    public class InternalLoginRequest : LoginRequest
    {
        
    }

    public class ExternalLoginRequest : LoginRequest
    {
        
    }
}