using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using WebApplication1.CustomValidation;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        [Display(Name = "id")]
        public int id { get; set; }
        [Display(Name = "login")]
        [Required]
        [MaxLength(30)]
        //[Remote("IsAlreadySigned", "User", HttpMethod = "POST", ErrorMessage = "Login Already Exist")]
        [CustomValidation.CustomAttribute(ErrorMessage = "Login is Blocked")]
        public string login { get; set; }
        [Display(Name = "password")]
        [Required]
        [MaxLength(30, ErrorMessage = "Length too long")]
        public string password { get; set; }
        [Display(Name = "ProfileId")]
        [ForeignKey("Profile")]

        [Range(1, 100000)]
        public int ProfileId { get; set; }

    }
}
