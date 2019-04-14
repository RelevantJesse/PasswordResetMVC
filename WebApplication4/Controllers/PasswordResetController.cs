using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class PasswordResetController : Controller
    {
        // GET: PasswordReset
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginRequest request)
        {
            UserContext context = new UserContext();

            var user = context.LoginAccounts.FirstOrDefault(u => u.Email == request.Email);

            if (user != null)
            {
                // send an email
                request.IsValidUser = true;
                request.AccessToken = new Guid();
                request.IsCompletedReset = false;
                request.IsTimedOut = false;
                request.RequestedDate = DateTime.Now;

                // Insert record into the audit table
                context.LoginRequests.Add(request);
                context.SaveChanges();

                string email = @"To reset your password, use the following link: \n
http://mycoolsite.com/stuff/passwordreset?token=" + request.AccessToken;

                myEmailApi.SendEmail(email);

            }
            else
            {
                request.IsValidUser = false;

                // log a non-user reset request to audit table
                context.LoginRequests.Add(request);
                context.SaveChanges();
            }

            return View();
        }
    }
}