using AddressServiceDAWA.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddressServiceDAWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        [Route("GetAddressInfo/{address}")]
        public async Task<string> GetAddressInfo([FromRoute] string address)
        {
            return await _addressService.GetAddressData(address);
        }
    }
}
