using System.Collections.Generic;
using System.Threading.Tasks;
using WebGentle.BookStore.Model;

namespace WebGentle.BookStore.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}