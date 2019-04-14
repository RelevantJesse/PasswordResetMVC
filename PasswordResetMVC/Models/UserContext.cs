using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PasswordResetMVC.Models
{
    public class UserContext : DbContext
    {
        public DbSet<LoginAccount> LoginAccounts { get; set; }
        public DbSet<LoginRequest> LoginRequests { get; set; }
    }
}