using Application.JSONResponseModel.NumLookUpService;

namespace Application.Interfaces.Services.GatewayServices
{
    public interface INumLookUpService
    {
        Task<NumberLookUpResponseModel> VerifyPhoneNumber(string phoneNumber, string countryCode);
    }
}