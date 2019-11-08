using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.CustomValidation
{
    public class CustomAttribute : ValidationAttribute

    {
        public override bool IsValid(object value)
        {
            var property = value  as string ;
            if (property == null)
            {
                return false;
            }
             if (property=="Nikita")
            {
                return false;
            }
            return true;
        }


    }
}
