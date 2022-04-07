
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleBiblioteca.Models
{
    public class BookModel 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string PublishingCompany { get; set; }

    }
}
