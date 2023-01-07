using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
   public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        public string ContackName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
