using System.Threading.Tasks;
using WebGentle.BookStore.Model;

namespace WebGentle.BookStore.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmail);
        Task SendConfirmationEmail(UserEmailOptions userEmailOptions);
        Task SendForgetEmail(UserEmailOptions userEmailOptions);
    }
}