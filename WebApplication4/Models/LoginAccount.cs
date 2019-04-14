using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class LoginAccount
    {
        public Guid Id;
        public string Username;
        public string Email;
        public bool IsInternal;

        public LoginAccount()
        {
            Id = new Guid();
        }
    }
}