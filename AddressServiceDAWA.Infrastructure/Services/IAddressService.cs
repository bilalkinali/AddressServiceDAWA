namespace AddressServiceDAWA.Infrastructure.Services
{
    public interface IAddressService
    {
        Task<string> GetAddressData(string address);
    }
}
