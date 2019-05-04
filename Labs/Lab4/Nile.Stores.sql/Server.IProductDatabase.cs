using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.sql
{
    class Server : IProductDatabase
    {
        public Product Add( Product product )
        {
            throw new NotImplementedException();
        }

        public Product Get( int id )
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove( int id )
        {
            throw new NotImplementedException();
        }

        public Product Update( int id, Product product )
        {
            throw new NotImplementedException();
        }
    }
}
