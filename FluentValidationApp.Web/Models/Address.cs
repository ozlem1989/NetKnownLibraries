﻿namespace FluentValidationApp.Web.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        // tracking : 
        public virtual Customer Customer { get; set; }

    }
}
