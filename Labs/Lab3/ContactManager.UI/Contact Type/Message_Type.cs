using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Type
{
    class Message_Type : IMessageService
    {
        private Contact _contact;
        private string _body;
        
        //string for the contact
        public Contact Contact { get => _contact; set => _contact = value; }

        //string for the body
        public string Body { get => _body; set => _body = value; }

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            // Body can't be empty
            if (String.IsNullOrEmpty(Body))
                items.Add(new ValidationResult("Body is required.", new[] { nameof(Body) }));

            // Subject can't be empty 
            if (String.IsNullOrEmpty(Subject))
                items.Add(new ValidationResult("Subject is required.", new[] { nameof(Subject) }));
            
            return items;
        }

        // sent items
        public Contact Send( string m )
        {
            throw new NotImplementedException();
        }

        // Subject string
        public string Subject
        {
            get => Subject ?? "";
            //set { _name = value ?? ""; }
            set => Subject = value ?? "";
        }
        
    }
}
