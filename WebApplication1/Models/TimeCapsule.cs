using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TimeCapsule
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [ForeignKey("TimeCapsuleFile")]
        public int TimeCapsuleFileId { get; set; }
        [ForeignKey("User")]
        [Required]
        [Range(1, 100000)]
        public int UserSource { get; set; }
        [ForeignKey("User")]
        [Required]
        [Range(1, 100000)]
        public int UserDestination { get; set; }
    }
}
