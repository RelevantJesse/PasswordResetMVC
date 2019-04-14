using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class LoginRequest
    {
        public string Email;
        public DateTime RequestedDate;
        public bool IsCompletedReset;
        public bool IsTimedOut;
        public bool IsValidUser;
        public Guid? AccessToken;
    }

    public class InteralLoginRequest : LoginRequest
    {
        
    }

    public class ExternalLoginRequest : LoginRequest
    {
        
    }
}