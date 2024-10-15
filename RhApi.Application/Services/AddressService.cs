using RhApi.Application.IServices;
using RhApi.Domain;
using RhApi.Domain.DTO;
using RhApi.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RhApi.Application.Services
{
    internal class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly HttpClient _httpClient;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<Address> GetAddressByCepAsync(string cep)
        {
            var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var endereco = JsonSerializer.Deserialize<AddressDTO>(jsonResponse);


            if (endereco == null) throw new Exception("CEP não encontrado.");

            return new Address
            {
                Cep = endereco.Cep,
                NameAdress = endereco.Logradouro,
                Complent = endereco.Complemento,
                Neighborhood = endereco.Bairro,
                City = endereco.Localidade,
                State = endereco.Uf,
            };
        }
    }
}
