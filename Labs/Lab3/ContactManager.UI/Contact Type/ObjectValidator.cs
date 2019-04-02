/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_Type

{
    /// <summary>Helper class to validate <see cref="IValidatableObject"/> types.</summary>
    public class ObjectValidator
    {
        ///// <summary>Validates an object.</summary>
        /// <param name="value">The object to validate.</param>
        /// <exception cref="ValidationException">The value is invalid.</exception>
        public static void Validate( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value));

            //No access to instance members
            //_duh = 10;
        }

        //private int _derp;
    }
}

