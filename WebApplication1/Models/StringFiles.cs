using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class StringFiles
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(10000000)]
        public string files { get; set; }
    }
}
