using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using toDoApi.Data;
using toDoApi.Models;
using toDoApi.Models.Entities;

namespace toDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class toDoController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public toDoController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllToDoTasks()
        {
            return Ok(dbContext.toDos.ToList());
        }
        [HttpPost]
        public IActionResult AddNewTodoTask(AddToDoDto addToDoDto)
        {
            var newToDo = new toDo()
            {
                toDoNo = addToDoDto.toDoNo,
                ToDoName = addToDoDto.ToDoName,
                CreatedDate = addToDoDto.CreatedDate,
                TargetDate = addToDoDto.TargetDate,
            };
            dbContext.toDos.Add(newToDo);
            dbContext.SaveChanges();

            return Ok(newToDo);
        }

        //[HttpGet]
        //public Int32 getNextNumber()
        //{
        //    Int32 nextNo = 0;
        //    if(dbContext.toDos.Any())
        //    {
        //        var maxNo = dbContext.toDos.Max(t => t.toDoNo);
        //        nextNo = Convert.ToInt32(maxNo);
        //    }
        //    nextNo++;
        //    return nextNo;
        //}
    }
}
