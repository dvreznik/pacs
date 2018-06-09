using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Models
{
    public class GymMember
    {
        //auto increment filed for count
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GymMemberId { get; set; }
        // first name
        [Required(ErrorMessage = "Please enter your name")]
        public string FirstName { get; set; }
        // last name
        [Required(ErrorMessage = "Please enter Last name")]
        public string LastName { get; set; }
        // date of brthday
        public DateTime BirthDate { get; set; }
        // date of registration for discount
        public DateTime DateRegistration { get; set; }
        // email for sending info
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Please enter а valid email address")]
        public string Email { get; set; }
        // phone for sending info
        [Required(ErrorMessage = "Please enter phone numЬer")]
        public string PhoneNumber { get; set; }
        // if a member is a part of staff
        public bool Staff { get; set; }
        // photo
        public string RelImage { get; set; }
    }
}
