using System;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;
using IdentityServer3.Core.Services.Default;
using IdentityServer3.Core.Services.InMemory;
using Microsoft.AspNet.Identity.EntityFramework;
using Praxis.IdentityServer.Identity;
using Praxis.IdentityServer.Identity.Users;

namespace Praxis.IdentityServer.Configuration
{
    public class IdentityServerFactory
    {
        public static IdentityServerServiceFactory Configure(string connectionString)
        {
            var factory = new IdentityServerServiceFactory();

            var scopeStore = new InMemoryScopeStore(Praxis.IdentityServer.Scopes.Get());
            factory.ScopeStore = new Registration<IScopeStore>(scopeStore);
            var clientStore = new InMemoryClientStore(Praxis.IdentityServer.Clients.Get());
            factory.ClientStore = new Registration<IClientStore>(clientStore);
            factory.CorsPolicyService = new Registration<ICorsPolicyService>(new DefaultCorsPolicyService { AllowAll = true });
            factory.ConfigureUserService(connectionString);
            return factory;
        }
    }

    public static class UserServiceExtensions
    {
        public static void ConfigureUserService(this IdentityServerServiceFactory factory, string connString)
        {
            factory.UserService = new Registration<IUserService, UserService>();
            factory.Register(new Registration<UserManager>());
            factory.Register(new Registration<UserStore>());
            factory.Register(new Registration<Context>(resolver => new Context(connString)));
            using (var ctx = new Context(connString))
            {
                var manager = new UserManager(new UserStore(ctx));
                var admin = manager.Users.Where(x => x.UserName == "admin@mm.com").SingleOrDefault();
                if (admin == null)
                {
                    admin = new User();
                    admin.UserName = "admin@praxis.com";
                    admin.Email = "admin@praxis.com";
                    var role = new IdentityUserClaim() { UserId = admin.Id, ClaimType = ClaimTypes.Role, ClaimValue = "superAdmin" };

                    admin.Claims.Add(role);
                    manager.Create(admin, "123qwe!@#QWE");
                }
            }

        }
    }

    public class UserService : AspNetIdentityUserService<User, string>
    {
        public UserService(UserManager userMgr)
            : base(userMgr)
        {
        }
    }

    public class CustomUserSerivce : IUserService
    {
        public Task AuthenticateExternalAsync(ExternalAuthenticationContext context)
        {
            int i = 0;
            i++;
            return new Task(() => { });
        }

        public Task AuthenticateLocalAsync(LocalAuthenticationContext context)
        {
            int i = 0;
            i++;
            return new Task(() => { });
        }

        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            int i = 0;
            i++;
            return new Task(() => { });
        }

        public Task IsActiveAsync(IsActiveContext context)
        {
            int i = 0;
            i++;
            return new Task(() => { });
        }

        public Task PostAuthenticateAsync(PostAuthenticationContext context)
        {
            int i = 0;
            i++;
            return new Task(() => { });
        }

        public Task PreAuthenticateAsync(PreAuthenticationContext context)
        {
            int i = 0;
            i++;
            return new Task(() => { });
        }

        public Task SignOutAsync(SignOutContext context)
        {
            int i = 0;
            i++;
            return new Task(() => { });
        }
    }
}
