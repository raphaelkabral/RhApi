using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RhApi.Domain
{
    public class Company
    {
        public int Id { get; set; }
        public string TypeCompany { get; set; } 
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public int AddressId { get; set; } // Foreign key for Address
        public Address Address { get; set; } // Navigation property

        public int UserId { get; set; } // Foreign key for User
        public User User { get; set; } // Navigation property
    }
}
