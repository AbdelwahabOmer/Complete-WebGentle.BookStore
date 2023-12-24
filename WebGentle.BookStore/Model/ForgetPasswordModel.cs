using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle.BookStore.Model
{
    public class ForgetPasswordModel
    {
        [Required, EmailAddress, Display(Name = "Registered Email")]
        public string Email { get; set; }
        public bool EmailSent { get; set; }
    }
}
