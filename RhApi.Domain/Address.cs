using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhApi.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string NameAdress { get; set; }
        public string Complent { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }        

        public ICollection<Company> Companies { get; set; }
    }
}
