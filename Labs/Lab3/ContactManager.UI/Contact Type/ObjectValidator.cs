/*
 * ITSE 1430
 */
using System.ComponentModel.DataAnnotations;

namespace Contact_Type

{
    /// <summary>Helper class to validate <see cref="IValidatableObject"/> types.</summary>
    public class ObjectValidator
    {
        ///// <summary>Validates an object.</summary>
        /// <param name="contact">The object to validate.</param>
        /// <exception cref="ValidationException">The value is invalid.</exception>
        public static void Validate( /*IValidatableObject value*/ Contact contact )
        {
            Validator.ValidateObject(contact, new ValidationContext(contact));

            //No access to instance members
            //_duh = 10;
        }

        //private int _derp;
    }
}

