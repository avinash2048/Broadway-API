using BroadwayInfoSys.Domain;
using BroadwayInfoSys.Domain.JwtAuth;
using BroadwayInfoSys.Utility.CommonModel.JwtAuth;
using BroadwayInfoSys.Utility.Interface;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayInfoSys.Utility.Implementation
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly EfContext _context;
        public UserService(ILogger<UserService> logger,EfContext context)
        {
            _logger = logger;
            _context = context;
        }

        public bool IsValidUserCredentials(string userName, string password)
        {
            ApplicationUser applicationUser = _context.ApplicationUser.Where(x => x.Username == userName && x.Password == password).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(userName) || applicationUser.Username==null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(password)|| applicationUser.Password==null)
            {
                return false;
            }

            return true;
        }

        public bool IsAnExistingUser(string userName)
        {
            ApplicationUser applicationUser = _context.ApplicationUser.Where(x => x.Username == userName).FirstOrDefault();
            if (applicationUser.Username == null)
            {
                return false;
            }
            return true;
        }

        public string GetUserRole(string userName)
        {
            if (!IsAnExistingUser(userName))
            {
                return string.Empty;
            }

            if (userName == "admin")
            {
                return UserRoles.Admin;
            }

            return UserRoles.BasicUser;
        }
        public async Task<DataResult> RegisterAsync(ApplicationUser model)
        {
            ApplicationUser applicationuser = new ApplicationUser();
            await _context.ApplicationUser.AddAsync(applicationuser);
            return new DataResult
            {
                response = "Success",
                responseCode = "000"
            };
                
             
             
        }
    }

     
}
 