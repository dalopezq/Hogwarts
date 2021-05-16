using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hogwarts.Models.Validaciones
{
    public class ValidarEscuelaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> Escuela = new List<string>()
            {
                "Gryffindor",
                "Hufflepuff",
                "Ravenclaw",
                "Slytherin"
            };

            foreach (string str in Escuela)
            {
                if (str == value.ToString()) //Checks if String1 list has the current string.
                {
                    return ValidationResult.Success;
                }     
            }

            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMessage);
        }
    }
}
