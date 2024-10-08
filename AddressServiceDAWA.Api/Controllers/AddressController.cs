using AddressServiceDAWA.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddressServiceDAWA.Api.Controllers
{
    [Route("api/adresser")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        //[Route("GetAddressInfo/{address}")]
        public async Task<string> GetAddressInfo(string vejnavn, string husnr, string postnr)
        {
            return await _addressService.GetAddressDataMini(vejnavn, husnr, postnr);
        }
    }
}
