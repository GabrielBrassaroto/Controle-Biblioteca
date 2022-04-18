
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleBiblioteca.Models
{
    public class BookModel 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Enter the PublishingCompany")]
        public string PublishingCompany { get; set; }

    }
}
