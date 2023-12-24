using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Helpers;

namespace WebGentle.BookStore.Model
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "minimum 3 chars")]
        //[MyCustomValidation("")]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        [Required]
        public int TotalPages { get; set; }


        [Display(Name ="Choose cover photo")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
        public string CoverPhotoUrl { get; set; }


        [Display(Name = "Choose gallery photos")]
        [Required]
        public IFormFileCollection GalleryPhotos { get; set; }

        public List<GalleryModel> Gallery { get; set; }


        [Display(Name = "upload pdf book")]
        [Required]
        public IFormFile BookPdf { get; set; }
        public string BookPdfUrl { get; set; }
    }
}
