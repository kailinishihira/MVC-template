using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/task/list")]
        public ActionResult TaskList()
        {
          Task newTask = new Task(Request.Query["new-task"]);
          return View(newTask);
        }

        [HttpPost("/task/create")]
        public ActionResult CreateTask()
        {
          Task newTask = new Task (Request.Form["new-task"]);
          newTask.Save();
          return View(newTask);
        }

    }
}
