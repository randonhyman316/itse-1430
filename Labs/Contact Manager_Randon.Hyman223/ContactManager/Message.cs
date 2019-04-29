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
    public class Message : IValidatableObject
    {
        private string _name = "";
        public string Name
        {
            get => _name ?? "";
            set => _name = value;
        }

        private string _emailAddress = "";
        public string EmailAddress
        {
            get => _emailAddress ?? "";
            set => _emailAddress = value;
        }

        private string _subject = "";
        public string Subject
        {
            get => _subject ?? "";
            set => _subject = value;
        }

        private string _messageText = "";
        public string MessageText
        {
            get => _messageText ?? "";
            set => _messageText = value;
        }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Subject))
                yield return new ValidationResult("Subject is required.",
                                new[] { nameof(Subject) });
        }
    }
}