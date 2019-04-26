/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;

namespace Nile
{
    /// <summary>Provides a database of <see cref="Product"/> items.</summary>
    public interface IProductDatabase
    {
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="contact"/> is not valid.</exception>
        /// <exception cref="ArgumentException">The contact already exists.</exception>
        /// <returns>The added product.</returns>
        Product Add ( Product product );

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to zero.</exception>
        Product Get ( int id );

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        IEnumerable<Product> GetAll ();

        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        void Remove ( int id );

        /// <summary>Updates a product.</summary>
        /// <param name="id">The contact to update.</param>
        /// <param name="product">The product to update.</param>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="contact"/> is not valid.</exception>
        /// <exception cref="ArgumentException">
        /// <returns>The updated product.</returns>
        Product Update( int id, Product product );
    }
}