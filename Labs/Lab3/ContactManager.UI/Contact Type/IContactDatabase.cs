using System;
using System.Collections.Generic;

namespace Contact_Type
{
    public interface IContactDatabase
    {
        /// <param name="contact">The contact to add.</param>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="contact"/> is invalid.</exception>
        /// <exception cref="ArgumentException">A contact with the same name already exists.</exception>
        Contact Add( Contact contact );
        /// <param name="id">The ID of the game.</param>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="contact"/> is invalid.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to 0.</exception>
        /// <exception cref="ArgumentException">A contact with the same name already exists.</exception>
        void Delete( int id );
        /// <summary>Gets a contact.</summary>
        /// <param name="id">The ID of the contact.</param>
        /// <returns>The contact, if any.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to 0.</exception>
        Contact Get( int id );

        /// <summary>Gets all contact.</summary>
        /// <returns>The list of contacts.</returns>
        IEnumerable<Contact> GetAll();

        /// <summary>Updates an existing contact.</summary>
        /// <param name="id">The ID of the existing contact.</param>
        /// <param name="contact">The contact to add.</param>
        /// <returns>The updated contact.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to 0.</exception>
        /// <exception cref="ArgumentException">The game does not exist.
        /// <para>-or-</para>
        /// A contact with the same name already exists.
        /// 
        /// </exception>
        /// <exception cref="ValidationException"><paramref name="contact"/> is invalid.</exception>
       
        Contact Update( int id, Contact contact );
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="contact"/> is invalid.</exception>
        /// <exception cref="ArgumentException">A contact with the same name already exists.</exception>
       
        Contact Remove(int id, Contact contact);
    }
}