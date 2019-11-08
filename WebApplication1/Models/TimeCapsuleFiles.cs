using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TimeCapsuleFiles
    {
        [Key]
        public int id { get; set; }
        //1 - image , 2 - string
        [Required]
        [Range(1, 2)]
        public int type { get; set; }
        [Required]
        [Range(1, 100000)]
        public int FileId { get; set; }
    }
}
