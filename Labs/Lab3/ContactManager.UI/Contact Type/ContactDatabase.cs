using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Type
{
   public abstract class ContactDatabase : IContactDatabase
    {
        
        public Contact Add( Contact contact )
        {
            if (contact == null)
            {
                throw new ArgumentNullException(nameof(contact));
            }

            return Add(contact);
        }

        protected Contact AddFull( Contact contact )
        {
            throw new NotImplementedException();
        }

        public void Delete( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), 
                    "Id must be > 0.");

            Delete(id);
        }

        public Contact Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), 
                    "Id must be > 0.");

            return Get(id);
        }

        public IEnumerable<Contact> GetAll()
        {
            return GetAllCore();
        }

        //protected virtual Contact FindByName( string name )
        //{
        //    foreach (var contact in GetAllCore())
        //    {
        //        if (String.Compare(contact.Name, name, true) == 0)
        //            return contact;
        //    };

        //    return null;
        //}

        public Contact Update( int id, Contact contact )
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id),
                    "Id must be > 0.");
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            ObjectValidator.Validate(contact);

            var existing = GetCore(id);
            if (existing != null)
                throw new Exception("Contact does not exist.");

            //Name must be unique           
            var sameName = FindByName(contact.Name);
            if (sameName != null && sameName.Id != id)
                throw new Exception("Contact must be unique.");

            return Update(id, contact);
        }

        public Contact Remove( int id, Contact contact )
        {
            throw new NotImplementedException();
        }

        private string name { get; set; }

        private string email { get; set; }

        protected abstract Contact AddCore( Contact contact );

        protected abstract void DeleteCore( int id );

        protected virtual Contact FindByName( string name )
        {
            return (from contact in GetAllCore()
                    where String.Compare(contact.Name, name,
                    true) == 0
                    select contact).FirstOrDefault();
        }

        protected abstract Contact GetCore( int id );

        protected abstract IEnumerable<Contact> GetAllCore();

        protected abstract Contact UpdateCore( int id, Contact newGame );

    }
    
 }   
    
