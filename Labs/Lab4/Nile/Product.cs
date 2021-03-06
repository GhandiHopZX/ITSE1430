/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nile
{
    /// <summary>Represents a product.</summary>
    public class Product : IValidatableObject
    {
        /// <summary>Gets or sets the unique identifier.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>Never returns null.</value>
        [Required(AllowEmptyStrings = false)]
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value?.Trim(); }
        }

        /// <summary>Gets or sets the description.</summary>
        [Required(ErrorMessage = "Description cannot be empty")]
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary>Gets or sets the price.</summary>
        [DataType(DataType.Currency)]
        public decimal Price { get; set; } = 0;      

        /// <summary>Determines if discontinued.</summary>
        public bool IsDiscontinued { get; set; }

        public override string ToString() => Name;

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            //Name is required
            if (String.IsNullOrEmpty(Name))
                items.Add(new ValidationResult("Name is required.", new[] { nameof(Name) }));

            //Price >= 0
            if (Price <= 0)
                items.Add(new ValidationResult("Price must be >= 0.", new[] { nameof(Price) }));

            return items;
        }

        #region Private Members

        private string _name;
        private string _description;
        #endregion

        public Product(string name) : this(name, 0)
        {
        }

        public Product( string name, decimal price )
        {
            Name = Name;
            Price = Price;
        }

        public Product()
        {
        }
    }
}
