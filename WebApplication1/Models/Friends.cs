using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Friends
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Range(1, 1000000)]
        [ForeignKey("User")]
        public int User1 { get; set; }
        [Required]
        [Range(1, 100000)]
        [ForeignKey("User")]
        public int User2 { get; set; }
        [Required]
        [Range(1, 3)]
        public bool status { get; set; }
    }
}
