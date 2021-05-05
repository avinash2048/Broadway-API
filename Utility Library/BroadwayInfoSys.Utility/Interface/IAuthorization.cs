using BroadwayInfoSys.Domain.JwtAuth;
using System;
using System.Collections.Immutable;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BroadwayInfoSys.Utility.Interface
{
    public interface IAuthorization
    {
        AuthResultant GenerateTokens(string username, Claim[] claims, DateTime now);
    }

}
