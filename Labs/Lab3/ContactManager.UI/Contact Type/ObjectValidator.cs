/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Type

{
    /// <summary>Helper class to validate <see cref="IValidatableObject"/> types.</summary>
    public static class ObjectValidator
    {
        ///// <summary>Validates an object.</summary>
        /// <param name="value">The object to validate.</param>
        /// <exception cref="ValidationException">The value is invalid.</exception>
        public static void Validate( IValidatableObject value )
        {
            Validator.ValidateObject(value, ValidationContext(value));

            throw new NotImplementedException();
            //No access to instance members
            //_duh = 10;
        }

        private static System.ComponentModel.DataAnnotations.ValidationContext ValidationContext( IValidatableObject value )
        {
            throw new NotImplementedException();
        }

        internal static void Validate( Contact contact )
        {
            throw new NotImplementedException();
        }


        //private int _derp;
    }
    
}

