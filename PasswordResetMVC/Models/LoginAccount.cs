using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PasswordResetMVC.Models
{
    public class LoginAccount
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsInternal { get; set; }

        public LoginAccount()
        {
            Id = new Guid();
        }
    }
}