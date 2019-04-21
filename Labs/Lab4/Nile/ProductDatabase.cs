using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    public abstract class ProductDatabase : IProductDatabase
    {
        public Product Add( Product product )
        {
            //Validate input
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            //Product not yet kosher.... 
            //Validation call
            ObjectValidator.Validate(product);

            //need unique names are need
            var existing = FindByName(product.Name);
            if (existing != null)
                throw new Exception("Unique name is needed.");

            return AddCore(product);
        }

        protected virtual Product FindByName( string name )
        {
            //LINQ
            //select
            //from
            //where
            // => IEnumerable<T>
            return (from product in GetAllCore()
                    where String.Compare(product.Name, name, true) == 0
                    //orderby game.Name, game.Id descending
                    select product).FirstOrDefault();

            //Extension method equivalent
            //return GetAllCore().Where(game => String.Compare(game.Name, name, true) == 0)
            //            .Select(game => game)
            //            .FirstOrDefault();

            //foreach (var game in GetAllCore())
            //{
            //    if (String.Compare(game.Name, name, true) == 0)
            //        return game;
            //};

            //return null;
        }

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract Product AddCore( Product product );

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( Product newProduct );

        public Product Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            return GetCore(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return GetAllCore();
        }

        protected abstract Product GetCore( int id );
        
        protected abstract void Remove( int id );

        public Product Update( Product product )
        {
            //Validate
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            ObjectValidator.Validate(product);

            //Game names must be unique            
            var sameName = FindByName(product.Name);
            if (sameName != null)
                throw new Exception("Product must have a name.");

            return UpdateCore(product);
        }

        void IProductDatabase.Remove( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            RemoveCore(id);
        }
    }
}
