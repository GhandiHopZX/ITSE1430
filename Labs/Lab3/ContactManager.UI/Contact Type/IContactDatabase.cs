using System;

namespace Contact_Type
{
    public interface IContactDatabase
    {
        //bool Validator
        //{
        //        if (String.IsNullOrEmpty(Name))
        //        {
        //            throw new ArgumentNullException(nameof(Name));
        //        };
        //        return false;

        //    {/* Name = ""; Email = ""; */}
        //}

        /// <summary>Adds a new contact.</summary>
        /// <param name="contact">The contact to add.</param>
        /// <returns>The new contact.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="contact"/> is invalid.</exception>
        /// <exception cref="ArgumentException">A contact with the same name already exists.</exception>
        Contact Add( Contact contact );

    }
}