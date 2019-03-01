using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TesteLucas.Infrastructure.Context;
using TesteLucas.Models.EntityModel.Tasks;

namespace TesteLucas.Controllers
{
    // [Route("api/v1/Task")]
    public class TaskController : Controller
    {
        private readonly Context _context;

        public TaskController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Tasks.ToList();


            return View(list);
        }

        [Route("create"), HttpGet]
        public IActionResult Create()
        {
            var task = new Task();
            TypeTask();

            return View(task);
        }

        [Route("create"), HttpPost]
        public IActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();

                return RedirectToAction("index");
            }

            return View(task);
        }

        [Route("edit"), HttpGet]
        public IActionResult Edit([FromQuery] int Id)
        {
            var task = _context.Tasks.Find(Id);
            TypeTask();

            return View(task);

        }

        [Route("edit"), HttpPost]
        public IActionResult Editing(Task _task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Update(_task);
                _context.SaveChanges();

                return RedirectToAction("index");
            }

            return View(_task);
        }

        [Route("delete/{id}"), HttpGet]
        public IActionResult Delete(int Id)
        {
            var task = _context.Tasks.Find(Id);

            return View(task);
        }

        [Route("delete/{id}"), HttpPost]
        public IActionResult Deleting(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();

                return RedirectToAction("index");
            }
            return View(task);
        }

        [Route("details/{id}"), HttpGet]
        public IActionResult Details(int Id)
        {
            var task = _context.Tasks.Find(Id);

            return View(task);
        }

        public void TypeTask()
        {
            var ItensTypeTask = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text="To Do / À Fazer"},
                new SelectListItem{Value = "2", Text="Doing / Fazendo"},
                new SelectListItem{Value = "3", Text="Done / Feito"},
                new SelectListItem{Value = "4", Text="Backlog / Ideias"}
            };

            ViewBag.ItemTask = ItensTypeTask;
        }
    }
}