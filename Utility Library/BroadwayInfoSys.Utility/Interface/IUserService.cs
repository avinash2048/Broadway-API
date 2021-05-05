using BroadwayInfoSys.Domain;
using BroadwayInfoSys.Utility.CommonModel.JwtAuth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BroadwayInfoSys.Utility.Interface
{
    public interface IUserService
    {
        bool IsAnExistingUser(string userName);
        bool IsValidUserCredentials(string userName, string password);
        string GetUserRole(string userName);
        Task<DataResult> RegisterAsync(ApplicationUser model);
        
    }
}

