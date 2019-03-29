using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Type
{
    public class Contact : IContactDatabase
    {
        public int Id { get; set; }
        public string Name
        {
            get { return name ?? ""; }
            set { name = value ?? ""; }
        }
        public string Email
        {
            get { return email ?? ""; }
            set { email = value ?? ""; }
        }

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            //Name is required
            if (String.IsNullOrEmpty(Name))
                items.Add(new ValidationResult("Name is required.", new[] { nameof(Name) }));

            //Email Address is required
            if (String.IsNullOrEmpty(Email))
                items.Add(new ValidationResult("Email is required.", new[] { nameof(Email) }));

            return items;
        }

        public Contact Add( Contact contact )
        {
            throw new NotImplementedException();
        }

        public void Delete( int id )
        {
            throw new NotImplementedException();
        }

        public Contact Get( int id )
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact Update( int id, Contact game )
        {
            throw new NotImplementedException();
        }

        private string name { get; set; }

        private string email { get; set; }

    }

    public class ValidationContext
    {
    }

    public class ValidationResult
    {
        private string v1;
        private string[] v2;

        public ValidationResult( string v1, string[] v2 )
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
