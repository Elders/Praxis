
using System;
using System.Linq;
using System.Threading.Tasks;
using Praxis.IdentityManager.Models;

namespace Praxis.IdentityManager.Controllers
{
    public class RegisterUserController
    {
        public UserManager userManager;

        public RegisterUserController(UserManager userManager)
        {
            this.userManager = userManager;
        }


        public async Task<string> Index(string name)
        {
            try
            {
                var result = await userManager.CreateAsync(new User(name), "123qwe");
                return result.Succeeded + result.Errors.FirstOrDefault();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
