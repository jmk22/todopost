using Nancy;
using nancytest.Objects;

namespace ToDoList
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
              return View["add_new_task.html"];
            };
            Post["/task_added"] = _ => {
              var NewTask = new Task{
                Description = Request.Form["new-task"]
              };
              Task.Save(NewTask.Description);
              return View["task_added.html", NewTask];
            };
            Get["/view_all_tasks"] = _ => {
              var AllTasks = Task.ListOfTasks;
              return View["view_all_tasks.html", AllTasks];
            };
            Post["/tasks_cleared"] = _ => {
              Task.ClearAll();
              return View["tasks_cleared.html"];
            };
        }
    }
}
