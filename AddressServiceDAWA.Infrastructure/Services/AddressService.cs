namespace AddressServiceDAWA.Infrastructure.Services
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        public AddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        async Task<string> IAddressService.GetAddressData(string address)
        {
            return await _httpClient.GetStringAsync(@"address/{address}");
        }
    }
}
