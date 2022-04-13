using ControleBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleBiblioteca.Repository
{
    public interface IBookRepository
    {
        BookModel Update(BookModel book);

        BookModel Add(BookModel book);

        List<BookModel> FindAll();

        BookModel FindById(int id);
    }
}
