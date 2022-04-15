using ControleBiblioteca.Models;
using ControleBiblioteca.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleBiblioteca.Controllers
{
    public class BookController : Controller
    {

        private readonly IBookRepository _bookRepository;

        //contrtutor para injetar o repositorio 
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            List<BookModel> books = _bookRepository.FindAll();
            return View(books);
        }

        public IActionResult Criar()
        {
            return View();
        }


        public IActionResult Edit(int Id)
        {
            BookModel book = _bookRepository.FindById(Id);
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BookModel bookModel)
        {
            _bookRepository.Add(bookModel);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            BookModel book = _bookRepository.FindById(Id);
            return View(book);
        }

        public IActionResult DeleteConfirm(int Id)
        {

            _bookRepository.Delete(Id);
            return RedirectToAction("Index");
        }



        [HttpPost]
        public ActionResult Edit(BookModel book)
        {

            _bookRepository.Update(book);
            return RedirectToAction("Index");
        }
    }
}
