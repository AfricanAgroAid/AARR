
using Application.Interfaces.Services.GatewayServices;
using Shouldly;

namespace GateayEndpointsTest;

public class NumLookUpService
{
    private readonly INumLookUpService _owms;

    [Fact]
    public async void Number_Should_Not_Return_False()
    {
        //Arrange 
        string Number = "08169364288";
        var response = await _owms.VerifyPhoneNumber(Number,"ng");
        response.Valid.ShouldBeTrue();
    }

}
