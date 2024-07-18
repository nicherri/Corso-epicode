using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SpedizioniWebApp.Stores
{
    public class CustomUserStore : IUserStore<IdentityUser>, IUserPasswordStore<IdentityUser>, IUserEmailStore<IdentityUser>, IUserRoleStore<IdentityUser>
    {
        private readonly List<IdentityUser> _users = new List<IdentityUser>();
        private readonly List<IdentityUserRole<string>> _userRoles = new List<IdentityUserRole<string>>();

        public Task<IdentityResult> CreateAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            _users.Add(user);
            return Task.FromResult(IdentityResult.Success);
        }

        public Task<IdentityResult> DeleteAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            _users.Remove(user);
            return Task.FromResult(IdentityResult.Success);
        }

        public void Dispose() { }

        public Task<IdentityUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            var user = _users.FirstOrDefault(u => u.Id == userId);
            return Task.FromResult(user);
        }

        public Task<IdentityUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var user = _users.FirstOrDefault(u => u.NormalizedUserName == normalizedUserName);
            return Task.FromResult(user);
        }

        public Task<string> GetNormalizedUserNameAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.NormalizedUserName);
        }

        public Task<string> GetUserIdAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id);
        }

        public Task<string> GetUserNameAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task SetNormalizedUserNameAsync(IdentityUser user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName;
            return Task.CompletedTask;
        }

        public Task SetUserNameAsync(IdentityUser user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.CompletedTask;
        }

        public Task<IdentityResult> UpdateAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(IdentityResult.Success);
        }

        public Task SetPasswordHashAsync(IdentityUser user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
            return Task.CompletedTask;
        }

        public Task<string> GetPasswordHashAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task SetEmailAsync(IdentityUser user, string email, CancellationToken cancellationToken)
        {
            user.Email = email;
            return Task.CompletedTask;
        }

        public Task<string> GetEmailAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.EmailConfirmed);
        }

        public Task SetEmailConfirmedAsync(IdentityUser user, bool confirmed, CancellationToken cancellationToken)
        {
            user.EmailConfirmed = confirmed;
            return Task.CompletedTask;
        }

        public Task<IdentityUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            var user = _users.FirstOrDefault(u => u.NormalizedEmail == normalizedEmail);
            return Task.FromResult(user);
        }

        public Task<string> GetNormalizedEmailAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.NormalizedEmail);
        }

        public Task SetNormalizedEmailAsync(IdentityUser user, string normalizedEmail, CancellationToken cancellationToken)
        {
            user.NormalizedEmail = normalizedEmail;
            return Task.CompletedTask;
        }

        public Task AddToRoleAsync(IdentityUser user, string roleName, CancellationToken cancellationToken)
        {
            var userRole = new IdentityUserRole<string> { UserId = user.Id, RoleId = roleName };
            _userRoles.Add(userRole);
            return Task.CompletedTask;
        }

        public Task RemoveFromRoleAsync(IdentityUser user, string roleName, CancellationToken cancellationToken)
        {
            var userRole = _userRoles.FirstOrDefault(ur => ur.UserId == user.Id && ur.RoleId == roleName);
            if (userRole != null)
            {
                _userRoles.Remove(userRole);
            }
            return Task.CompletedTask;
        }

        public Task<IList<string>> GetRolesAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            var roles = _userRoles.Where(ur => ur.UserId == user.Id).Select(ur => ur.RoleId).ToList();
            return Task.FromResult((IList<string>)roles);
        }

        public Task<bool> IsInRoleAsync(IdentityUser user, string roleName, CancellationToken cancellationToken)
        {
            var isInRole = _userRoles.Any(ur => ur.UserId == user.Id && ur.RoleId == roleName);
            return Task.FromResult(isInRole);
        }

        public Task<IList<IdentityUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            var usersInRole = _userRoles.Where(ur => ur.RoleId == roleName).Select(ur => _users.FirstOrDefault(u => u.Id == ur.UserId)).ToList();
            return Task.FromResult((IList<IdentityUser>)usersInRole);
        }
    }
}
