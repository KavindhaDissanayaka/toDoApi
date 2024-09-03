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
            var nexttodoNo = dbContext.toDos.Max(t => t.toDoNo);
            nexttodoNo++;
            var newToDo = new toDo()
            {
                toDoNo = nexttodoNo,
                ToDoName = addToDoDto.ToDoName,
                CreatedDate = addToDoDto.CreatedDate,
                TargetDate = addToDoDto.TargetDate,
            };
            dbContext.toDos.Add(newToDo);
            dbContext.SaveChanges();

            return Ok(newToDo);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult getToDoBYID(Guid id)
        {
            var selectedTask = dbContext.toDos.Find(id);
            if (selectedTask is null)
            {
                return NotFound();
            }
            return Ok(selectedTask);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult updatetask(Guid id, updateTask _updateTask)
        {
            var _Task = dbContext.toDos.Find(id);
            if(_Task is null)
            {
                return NotFound();
            }
            _Task.EndDate = _updateTask.EndDate;
            _Task.isDone = _updateTask.isDone;
            dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleateTask(Guid id)
        {
            var _Task = dbContext.toDos.Find(id);
            if(_Task is null)
            {
                return NotFound();
            }
            dbContext.toDos.Remove(_Task);
            dbContext.SaveChanges();
            return Ok();
        }
        //[HttpGet]
        //public Int32 nextTaskNumber()
        //{
        //    Int32 nextNo = 0;
        //    var _maxTask = dbContext.toDos.Max();
        //    if(_maxTask != null )
        //    {
        //        nextNo = _maxTask.toDoNo;
        //    }
        //    return nextNo++;
        //}
    }
}
