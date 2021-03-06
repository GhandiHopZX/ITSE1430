﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Type
{
    public class Contact : IContactDatabase
    {
        public int Id
        { get; set; }

        public string Name
        {
            get { return name ?? ""; }
            set { name = value ?? ""; }
        }
        public string Email
        {
            get {
                return email ?? "";
            }

            set { email = value ?? ""; }
        }

        public override string ToString() => Name;

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

        Contact IContactDatabase.Add( Contact contact )
        {
            throw new NotImplementedException();
        }

        void IContactDatabase.Delete( int id )
        {
            throw new NotImplementedException();
        }

        Contact IContactDatabase.Get( int id )
        {
            throw new NotImplementedException();
        }

        IEnumerable<Contact> IContactDatabase.GetAll()
        {
            throw new NotImplementedException();
        }

        Contact IContactDatabase.Update( int id, Contact contact )
        {
            throw new NotImplementedException();
        }

        public Contact Remove( int id, Contact contact )
        {
            throw new NotImplementedException();
        }

        //Constructors
        public Contact()
        {

        }

        //public Contact( string name, string email ) : this(name) 
        //{
        //}

        public Contact( string name, string email )
        {
            Name = name;
            Email = email;
        }
        
        #region
        private string name = "";
        private string email = "";
        private int id;
        #endregion
    }
}
