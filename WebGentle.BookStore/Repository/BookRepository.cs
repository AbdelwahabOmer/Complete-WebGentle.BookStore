using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Model;

namespace WebGentle.BookStore.Repository
{
    public class BookRepository
    {

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(a => a.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(a => a.Title.Contains(title) || a.Author.Contains(author)).ToList();
        }



        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Ali",Description="this is description for MVC",Category="Action",Language="English",TotalPages=250},
                new BookModel(){Id=2,Title="ASP",Author="Musa",Description="this is description for ASP",Category="Drama",Language="Arabic",TotalPages=140},
                new BookModel(){Id=3,Title="HTML",Author="Abdu",Description="this is description for HTML",Category="Comedy",Language="English",TotalPages=600},
                new BookModel(){Id=4,Title="C#",Author="Jamal",Description="this is description for C#",Category="Comedy",Language="Arabic",TotalPages=300},
                new BookModel(){Id=5,Title="JAVA",Author="Omnia",Description="this is description for JAVA",Category="Action",Language="English",TotalPages=750}
            };
        }

    }
}
