using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebGentle.BookStore.Model;

namespace WebGentle.BookStore.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userMogel);
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);
        Task<SignInResult> PasswordSignInAsync(SignInUserModel userModel);
        Task SignOutAsync();
        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);
        Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model);
        Task GenerateEmailTokenAsync(ApplicationUser user);
        Task GenerateForgetTokenAsync(ApplicationUser user);
        Task<ApplicationUser> GetUserByEmailAsync(string email);
    }
}