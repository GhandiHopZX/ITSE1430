using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    public static class Verify
    {
        /// <summary>Verifies a value is greater than another value.</summary>        
        /// <param name="name">The argument name.</param>
        /// <param name="value">The value to validate.</param>
        /// <param name="minValue">The value the instance must be greater than.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> must be greater than <paramref name="minValue"/>.</exception>
        public static void IsGreaterThan<T>( string name, T value, T minValue ) where T : IComparable<T>
        {
            if (value.CompareTo(minValue) <= 0)
                throw new ArgumentOutOfRangeException(name, $"{name} must be greater than {minValue}.");
        }

        /// <summary>Verifies a value is greater than or equal to another value.</summary>        
        /// <param name="name">The argument name.</param>
        /// <param name="value">The value to validate.</param>
        /// <param name="minValue">The value the instance must be greater than or equal to.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> must be greater than or equal to <paramref name="minValue"/>.</exception>
        public static void IsGreaterThanOrEqualTo<T>( string name, T value, T minValue ) where T : IComparable<T>
        {
            if (value.CompareTo(minValue) < 0)
                throw new ArgumentOutOfRangeException(name, $"{name} must be greater than or equal to {minValue}.");
        }

        /// <summary>Verifies a value is greater than zero.</summary>        
        /// <param name="name">The argument name.</param>
        /// <param name="value">The value to validate.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> must be greater than zero.</exception>
        public static void IsGreaterThanZero( string name, int value ) => IsGreaterThan(name, value, 0);

        /// <summary>Verifies a value is not <see langword="null"/>.</summary>
        /// <typeparam name="T">The type to validate.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <param name="value">The value to validate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <see langword="null"/>.</exception>
        public static void IsNotNull<T>( string name, T value ) where T : class
        {
            if (value == null)
                throw new ArgumentNullException(name);
        }

        /// <summary>Determines if an object is not <see langword="null"/> and valid.</summary>
        /// <typeparam name="T">The type to validate.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <param name="value">The value to validate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="value"/> is not valid.</exception>
        public static void IsNotNullAndValid<T>( string name, T value ) where T : class, IValidatableObject
        {
            IsNotNull(name, value);

            Validator.ValidateObject(value, new ValidationContext(value), true);
        }

        /// <summary>Determines if an object is valid.</summary>
        /// <typeparam name="T">The type to validate.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <param name="value">The value to validate.</param>
        /// <exception cref="InvalidOperationException"><paramref name="value"/> is not valid.</exception>
        /// <remarks>
        /// A <see langword="null"/> value is considered to be valid.
        /// </remarks>
        public static void IsValid<T>( string name, T value ) where T : IValidatableObject
        {
            if (value == null)
                return;

            Validator.ValidateObject(value, new ValidationContext(value), true);
        }

        /// <summary>Validates an object.</summary>
        /// <typeparam name="T">The type being validated.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>The errors, if any.</returns>
        public static IEnumerable<ValidationResult> Validate<T>( T value )
        {
            if (value == null)
                yield return null;

            var results = new Collection<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), results, true);
            foreach (var result in results)
                yield return result;
        }
    }
}
