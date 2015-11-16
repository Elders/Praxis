using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Praxis.IdentityManager.Models
{
    public class User : IdentityUser
    {
        private User() { }
        public User(string username)
        {
            UserName = username;
            ChangeName(username + Guid.NewGuid().ToString(), username + Guid.NewGuid().ToString());
        }

        public void ChangeName(string firstName, string lastName)
        {
            AddUniqueClaim(ClaimTypes.GivenName, firstName);
            AddUniqueClaim(ClaimTypes.GivenName, lastName);
        }


        private void AddUniqueClaim(string claimType, string claimValue)
        {
            var existingClaims = Claims.Where(x => x.ClaimType == claimType);
            //There may be more than one claim of this type
            foreach (var item in existingClaims.ToList())
            {
                Claims.Remove(item);
            }
            Claims.Add(UserClaimFactory.Create(this.Id, claimType, claimValue));
        }
    }

    public class UserClaimFactory
    {
        public static IdentityUserClaim Create(string userId, string claimType, string claimValue)
        {
            return new IdentityUserClaim { UserId = userId, ClaimType = claimType, ClaimValue = claimValue };
        }
    }

    public class Role : IdentityRole { }

    public class UserContext : IdentityDbContext<User, Role, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    {
        public UserContext(string connString)
            : base(connString)
        {
        }
    }

    public class UserStore : UserStore<User, Role, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    {
        public UserStore(UserContext ctx)
            : base(ctx)
        {
        }
    }

    public class UserManager : UserManager<User, string>
    {
        public UserManager(UserStore store)
            : base(store)
        {
            // this.ClaimsIdentityFactory = new ClaimsFactory();
        }
    }

    //public class ClaimsFactory : ClaimsIdentityFactory<User, string>
    //{
    //    public ClaimsFactory()
    //    {
    //        this.UserIdClaimType = IdentityServer3.Core.Constants.ClaimTypes.Subject;
    //        this.UserNameClaimType = IdentityServer3.Core.Constants.ClaimTypes.PreferredUserName;
    //        this.RoleClaimType = IdentityServer3.Core.Constants.ClaimTypes.Role;
    //    }



    //    public override async System.Threading.Tasks.Task<System.Security.Claims.ClaimsIdentity> CreateAsync(UserManager<User, string> manager, User user, string authenticationType)
    //    {
    //        var ci = await base.CreateAsync(manager, user, authenticationType);
    //        if (!String.IsNullOrWhiteSpace(user.FirstName))
    //        {
    //            ci.AddClaim(new Claim("given_name", user.FirstName));
    //        }
    //        if (!String.IsNullOrWhiteSpace(user.LastName))
    //        {
    //            ci.AddClaim(new Claim("family_name", user.LastName));
    //        }
    //        return ci;
    //    }
    //}

    public class RoleStore : RoleStore<Role>
    {
        public RoleStore(UserContext ctx)
            : base(ctx)
        {
        }
    }

    public class RoleManager : RoleManager<Role>
    {
        public RoleManager(RoleStore store)
            : base(store)
        {
        }
    }

}
