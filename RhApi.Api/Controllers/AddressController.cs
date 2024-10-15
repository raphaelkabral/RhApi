using Microsoft.AspNetCore.Mvc;
using RhApi.Application.IServices;

namespace RhApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetEndereco(string cep)
        {
            var endereco = await _addressService.GetAddressByCepAsync(cep);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }
    }
}
