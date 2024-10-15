using RhApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhApi.Application.IServices
{
    public interface IAddressService
    {
        Task<Address> GetAddressByCepAsync(string cep);
    }
}
