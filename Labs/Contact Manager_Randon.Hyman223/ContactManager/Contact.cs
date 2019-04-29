/******************
 * Randon Hyman
 * ITSE 1430   
 * 4/18/2019  
 *****************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact : IValidatableObject
    {
        private string _name = "";

        public string Name
        {
            get => _name ?? "";
            set => _name = value;
        }

        private string _email = "";

        public string Email
        {
            get => _email ?? "";
            set => _email = value;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required.",
                                new[] { nameof(Name) });

            if (String.IsNullOrEmpty(Email))
                yield return new ValidationResult("Email Address is required.",
                                new[] { nameof(Email) });

            if (!IsValidEmail(Email))
            {
                yield return new ValidationResult("Invalid Email. ",
                                new[] { nameof(Email) });
            }
        }

        bool IsValidEmail(string source)
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            }
            catch
            { };
            return false;
        }
    }
}