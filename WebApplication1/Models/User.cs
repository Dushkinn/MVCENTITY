using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        [Display(Name = "id")]
        public int id { get; set; }
        [Display(Name = "login")]
        public string login { get; set; }
        [Display(Name = "password")]
        public string password { get; set; }
        [Display(Name = "name")]
        public string name { get; set; }

    }
}
