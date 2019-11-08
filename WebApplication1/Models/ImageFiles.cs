using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ImageFiles
    {
        [Key]
        public int id { get; set; }
        public String Base64 { get; set; }
    }
}
