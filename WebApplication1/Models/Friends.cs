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
        [ForeignKey("User")]
        public int User1 { get; set; }
        [ForeignKey("User")]
        public int User2 { get; set; }
        public bool status { get; set; }
    }
}
