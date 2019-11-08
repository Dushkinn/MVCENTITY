using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Profile : IValidatableObject
    {

        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(100)]
        public string MobilePhone { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (MobilePhone[0]!='8' || MobilePhone.Length!=13)
            {
                yield return new ValidationResult("Incorrect MobilePhone");
            }
        }
    }
}
