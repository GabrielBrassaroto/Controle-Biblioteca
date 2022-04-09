using ControleBiblioteca.Data;
using ControleBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleBiblioteca.Repository
{
    public class BookRepository : IBookRepository
    {

        //variavel para ser utilizada dentro do repositorio
        private readonly LibaryContext _libaryContext;

        //colocar o construtor para utilizar o context e gravar os dados no banco 
        public BookRepository(LibaryContext libaryContext)
        {
            _libaryContext = libaryContext;
        }


        public BookModel Add(BookModel book)
        {
            _libaryContext.Books.Add(book);
            _libaryContext.SaveChanges();
            return book;
        }
    }
}
