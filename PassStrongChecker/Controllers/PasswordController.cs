using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PassStrongChecker.Response;

namespace PassStrongChecker.Controllers
{
    public class PasswordController : Controller
    {
        [HttpGet]
        public IActionResult Check()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckPasswordStrong(string password)
        {
            ResponseObj res = new ResponseObj();            
            if (String.IsNullOrEmpty(password))
            {
                res.message = "password is null or empty";
                res.count = 0;
                return Json(res);
            }

            int count = 0;
            // Check Password Length 
            if (Math.Max(password.Length , 7)>7)
            {
                count++;
                res.message = "length is greater than 7 ";
            }

            // cheking lower case in password
            
            string pattern = "[a-z]";
            if (Regex.Match(password, pattern).Success)
            {
                count++;
                res.message = "Lowercase is supported";
                res.count = count;
  
            }

            // cheking Uppercase in password
            pattern = "[A-Z]";
            if (Regex.Match(password,pattern).Success)
            {
                count++;
                res.message = "UpperCase is supported";
                res.count = count;

            }

            pattern = "[0-9]";
            if (Regex.Match(password, pattern).Success)
            {
                count++;
                res.message = "Digit is supported";
                res.count = count;

            }

            //pattern = "[\\!\\@\\#\\$]";
            //if (Regex.Match(password, pattern).Success)
            //{
            //    count++;
            //    res.message = "Spec simbol is supported";
            //    res.count = count;
            //}

            return Json(res);
        }
    }
}
