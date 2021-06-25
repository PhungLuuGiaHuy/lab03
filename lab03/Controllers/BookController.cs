using lab03.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab03.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            BookManagerContext context = new BookManagerContext();
            var listBook = context.books.ToList();
            return View(listBook);
        }
        [Authorize]
        public ActionResult Buy(int id)
        {
            BookManagerContext context = new BookManagerContext();
            book book = context.books.SingleOrDefault(p => p.id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        public ActionResult Create()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(book book)
        {
            BookManagerContext context = new BookManagerContext();
            context.books.AddOrUpdate(book);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }
        public ActionResult Edit(int id)
        {
            BookManagerContext context = new BookManagerContext();
            book book = context.books.SingleOrDefault(p => p.id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }


        [Authorize]
        [HttpPost]
        public ActionResult Edit(book book)
        {
            BookManagerContext context = new BookManagerContext();
            book bookUpdate = context.books.SingleOrDefault(p => p.id == book.id);
            if (bookUpdate != null)
            {
                context.books.AddOrUpdate(book);
                context.SaveChanges();
            }

            return RedirectToAction("ListBook");
        }
        public ActionResult Delete(int id)
        {
            BookManagerContext context = new BookManagerContext();
            book book = context.books.SingleOrDefault(p => p.id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [Authorize]
        [HttpPost]
        public ActionResult DeleteBook(int id)
        {
            BookManagerContext context = new BookManagerContext();
            book book = context.books.SingleOrDefault(p => p.id == id);
            if (book != null)
            {
                context.books.Remove(book);
                context.SaveChanges();
            }
            return RedirectToAction("ListBook");
        }
    }
}
