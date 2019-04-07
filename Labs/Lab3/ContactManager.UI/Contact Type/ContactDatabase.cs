using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Type
{
    class ContactDatabase : IContactDatabase
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
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            Delete(id);
        }

        public Contact Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            return Get(id);
        }

        public IEnumerable<Contact> GetAll()
        {
            return GetAll();
        }

        protected virtual Contact FindByName( string name )
        {
            foreach (var contact in GetAll())
            {
                if (String.Compare(contact.Name, name, true) == 0)
                    return contact;
            };

            return null;
        }

        public Contact Update( int id, Contact contact )
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            ObjectValidator.Validate(contact);

            var existing = Get(id);
            if (existing != null)
                throw new Exception("Contact does not exist.");

            //Game names must be unique            
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

    }

    public class ValidationContext
    {
        private Contact contact;

        private IValidatableObject value;

        public ValidationContext( Contact contact )
        {
            this.contact = contact;
        }

        public ValidationContext( IValidatableObject value )
        {
            this.value = value;
        }

        public override bool Equals( object obj )
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    //public class ValidationResult
    //{
    //    private string v1;
    //    private string[] v2;

    //    public ValidationResult( string v1, string[] v2 )
    //    {
    //        this.v1 = v1;
    //        this.v2 = v2;
    //    }
    //}
}
