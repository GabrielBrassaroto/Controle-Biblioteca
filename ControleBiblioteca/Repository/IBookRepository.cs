using ControleBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleBiblioteca.Repository
{
    interface IBookRepository
    {
        BookModel Add(BookModel book);
    }
}
