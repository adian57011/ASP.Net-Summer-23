using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.Models
{
    public class UserDto
    {
        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(5,ErrorMessage ="Maximum Character limit reached")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your age")]
        public string Age { get; set; }
        [Required(ErrorMessage ="Please fill your gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage ="Please enter your email")]
        [EmailAddress(ErrorMessage ="Email is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please fill up your contact information")]
        
        public string Contact { get; set; }
    }
}