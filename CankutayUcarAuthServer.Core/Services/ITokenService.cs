using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarAuthServer.Core.Configuration;
using CankutayUcarAuthServer.Core.Dtos;
using CankutayUcarAuthServer.Core.Models;

namespace CankutayUcarAuthServer.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
