using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class UserInfo
    {
        [Required] //attribute
        [RegularExpression("^[a-zA-Z]{1,40}$")]
        public string FirstName { set; get; }
        [Required]
        [RegularExpression("^[a-zA-Z]{1,40}$")]
        public string LastName { set; get; }
        [Required]
        [RegularExpression("^[0-9]{10}$")]
        public string PhoneNumber { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Password { set; get; }

        //List<UserInfo> users = new List<UserInfo>();

        public UserInfo()
        {
            FirstName = "First";
            LastName = "Last";
            PhoneNumber = "0";
            Email = "email";
            Password = "password";
        }
        public UserInfo(string fn, string ln, string pn, string em, string pw)
        {
            FirstName = fn;
            LastName = ln;
            PhoneNumber = pn;
            Email = em;
            Password = pw;
        }

    }
}