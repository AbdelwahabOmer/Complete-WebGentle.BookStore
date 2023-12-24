using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Data;
using WebGentle.BookStore.Model;

namespace WebGentle.BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreDbContext _bookStoreDbContext;

        public BookRepository(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }

        public async Task<int> AddBook(BookModel bookModel)
        {
            var data = new Books()
            {
                Title = bookModel.Title,
                Author = bookModel.Author,
                Description = bookModel.Description,
                LanguageId = bookModel.LanguageId,
                Category = bookModel.Category,
                TotalPages = bookModel.TotalPages,
                ImageUrl = bookModel.CoverPhotoUrl,
                BookPdfUrl = bookModel.BookPdfUrl,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };

            data.BookGallery = new List<BookGallery>();
            foreach (var file in bookModel.Gallery)
            {
                data.BookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }

            await _bookStoreDbContext.Books.AddAsync(data);
            await _bookStoreDbContext.SaveChangesAsync();
            return data.Id;
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            return await _bookStoreDbContext.Books.Select(bookModel => new BookModel
            {
                Id = bookModel.Id,
                Title = bookModel.Title,
                Author = bookModel.Author,
                Description = bookModel.Description,
                Category = bookModel.Category,
                LanguageId = bookModel.LanguageId,
                LanguageName = bookModel.Language.Name,
                TotalPages = bookModel.TotalPages,
                CoverPhotoUrl = bookModel.ImageUrl,
                BookPdfUrl = bookModel.BookPdfUrl
            }).ToListAsync();
        }

        public async Task<BookModel> GetBookById(int Id)
        {
            return await _bookStoreDbContext.Books.Where(a => a.Id == Id).Select(bookModel => new BookModel
            {
                Id = bookModel.Id,
                Title = bookModel.Title,
                Author = bookModel.Author,
                Description = bookModel.Description,
                Category = bookModel.Category,
                LanguageId = bookModel.LanguageId,
                LanguageName = bookModel.Language.Name,
                TotalPages = bookModel.TotalPages,
                CoverPhotoUrl = bookModel.ImageUrl,
                BookPdfUrl = bookModel.BookPdfUrl,
                Gallery = bookModel.BookGallery.Select(g => new GalleryModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    URL = g.URL
                }).ToList()

            }).FirstOrDefaultAsync();
        }

        public async Task<List<BookModel>> GetTopBooksAsync(int count)
        {
            return await _bookStoreDbContext.Books.Select(bookModel => new BookModel
            {
                Id = bookModel.Id,
                Title = bookModel.Title,
                Author = bookModel.Author,
                Description = bookModel.Description,
                Category = bookModel.Category,
                LanguageId = bookModel.LanguageId,
                LanguageName = bookModel.Language.Name,
                TotalPages = bookModel.TotalPages,
                CoverPhotoUrl = bookModel.ImageUrl,
                BookPdfUrl = bookModel.BookPdfUrl
            }).Take(count).ToListAsync();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return null;
        }

    }
}
