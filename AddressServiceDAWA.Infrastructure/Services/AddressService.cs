namespace AddressServiceDAWA.Infrastructure.Services
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        public AddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        async Task<string> IAddressService.GetAddressDataMini(string vejnavn, string husnr, string postnr)
        {
            return await _httpClient.GetStringAsync(
                $"adresser?vejnavn={vejnavn}&husnr={husnr}&postnr={postnr}&struktur=mini");
        }
    }
}
