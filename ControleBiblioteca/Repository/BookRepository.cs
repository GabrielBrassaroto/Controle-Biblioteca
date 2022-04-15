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

        public List<BookModel> FindAll()
        {
           return _libaryContext.Books.ToList();
        }

        public BookModel FindById(int Id)
        {
            return _libaryContext.Books.Find(Id);
        }

        public BookModel Add(BookModel book)
        {
            _libaryContext.Books.Add(book);
            _libaryContext.SaveChanges();
            return book;
        }

        public BookModel Update(BookModel book)
        {
            BookModel bookModel = FindById(book.Id);

            if (bookModel == null)
                throw new System.Exception("Book não foi localizado");
            bookModel.Name = book.Name;
            bookModel.Author  = book.Author;
            bookModel.PublishingCompany = book.PublishingCompany;

            _libaryContext.Books.Update(bookModel);
            _libaryContext.SaveChanges();
            return bookModel;

        }


        public bool Delete(int Id)
        {
            BookModel bookModel = FindById(Id);

            if (bookModel == null)
                throw new System.Exception("Book não foi localizado");

            _libaryContext.Books.Remove(bookModel);
            _libaryContext.SaveChanges();
            return true;

        }
    }
}
