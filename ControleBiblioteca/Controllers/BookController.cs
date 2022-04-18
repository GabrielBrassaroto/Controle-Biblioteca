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
        public ActionResult Create(BookModel book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bookRepository.Add(book);
                    TempData["MensagemSucesso"] = "Book Registered Successfully";
                    return RedirectToAction("Index");
                }
                return View(book);
            }
            catch (Exception ex)
            {
                TempData["MensagemFalha"] = $"Unregistered Book {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete(int Id)
        {
            BookModel book = _bookRepository.FindById(Id);
            return View(book);
        }

        public IActionResult DeleteConfirm(int Id)
        {

            try
            {
                bool deleted = _bookRepository.Delete(Id);
                if (deleted)
                {
                    TempData["MensagemSucesso"] = "Book Deleted Successfully";
                }
                else{

                    TempData["MensagemFalha"] = $"Undeleted Book";
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {


                TempData["MensagemFalha"] = $"Undeleted Book {ex.Message}";
                return RedirectToAction("Index");
            }
        }



        [HttpPost]
        public ActionResult Edit(BookModel book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bookRepository.Update(book);
                    TempData["MensagemSucesso"] = "Book Edited Successfully";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["MensagemFalha"] = $"Unedited Book {ex.Message}";
                return RedirectToAction("Index");
            }


            return View(book);
        }
    }
}
