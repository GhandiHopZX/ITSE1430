/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {        
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add ( Product product )
        {
            //Validate input 
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            //TODO: Check arguments
            //Validate the object
            ObjectValidator.Validate(product);

            //product
            var existing = FindByName(product.Name);

            //TODO: Validate product

            //Emulate database by storing copy
            return AddCore(product);
        }

        protected virtual Product FindByName( string name )
        {
            return (from game in GetAllCore()
                    where String.Compare(game.Name, name, true) == 0
                    //orderby game.Name, game.Id descending
                    select game).FirstOrDefault();
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            //TODO: Check arguments

            return GetCore(id);
        }
        
        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }
        
        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id needs to be greater than 0.");

            //TODO: Check arguments

            RemoveCore(id);
        }
        
        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update ( int id, Product product )
        {
            //TODO: Check arguments
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            //TODO: Validate product

            //Get existing product
            var existing = GetCore(id);
            if (existing == null)
                throw new Exception("Product does not exist.");

            //Product names must be unique
            var sameName = FindByName(product.Name);
            if (sameName != null && sameName.Id != id)
                throw new Exception("Product must be unique");

            return UpdateCore(existing, product);
        }

        #region Protected Members

        protected abstract Product GetCore( int id );

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );

        #endregion
    }
}
