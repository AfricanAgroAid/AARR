using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.GatewayServices
{
    public interface INumLookUpService
    {
        Task<bool> VerifyPhoneNumber(string phoneNumber);
    }
}