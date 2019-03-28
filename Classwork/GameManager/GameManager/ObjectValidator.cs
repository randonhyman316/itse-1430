/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    /// <summary>Helper class to validate <see cref="IValidatableObject"/> types.</summary>
    public class ObjectValidator
    {
        /// <summary>Validates an object.</summary>
        /// <param name="value">The object to validate.</param>
        /// <exception cref="ValidationException">The value is invalid.</exception>
        public void Validate ( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value));
        }
    }
}
