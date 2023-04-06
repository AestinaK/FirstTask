using Microsoft.AspNetCore.Mvc;
using FirstTask.Models;

using System.Diagnostics;
using FirstTask.Context;

namespace FirstTask.Controllers
{
    public class HelloController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        public HelloController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Hello()
        {
           // selec all record
            var dataselect = _context.Hellos.ToList();
            ViewBag.data = dataselect;
            return View();
        }

        [HttpPost]
        public IActionResult Hello (Hello hello)

        {
            
            Hello obj=new Hello()
            {
                Id=hello.Id,
                Name=hello.Name,
                Email=hello.Email,
                Phone=hello.Phone,
                Place=hello.Place,
                Time=hello.Time
            };
            _context.Hellos.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Hello");
        }
        //delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Hellos.Find(id);
            _context.Hellos.Remove(data);
            _context.SaveChanges();

            return RedirectToAction("Hello");
        }
        //update
        public IActionResult update(int id)
        {
            var data = _context.Hellos.Find(id);
            ViewBag.d = data;
            return View();

        }

        public IActionResult Update(Hello hello)
        {
            Hello obj = new Hello()
            {
                Id = hello.Id,
                Name = hello.Name,
                Email = hello.Email,
                Phone = hello.Phone,
                Place = hello.Place,
                Time = hello.Time
            };
            _context.Hellos.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Hello");
        }


    }
}
