using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class TodoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.toDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.toDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var values = context.toDoLists.Find(id);
            context.toDoLists.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.toDoLists.Find(id);
            return View(value);

        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList ToDoList)
        {
            context.toDoLists.Update(ToDoList);
            context.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value = context.toDoLists.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = context.toDoLists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");

        }




    }
}
