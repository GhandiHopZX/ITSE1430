using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Type
{
    class Message_Type : Contact
    {
        private Contact _contact;
        private string _body;

        public Contact Contact { get => _contact; set => _contact = value; }
        public string Body { get => _body; set => _body = value; }

        private string Subject(string input)
        {
            // Look for string validation check
            return input;
        }
        
    }
}
