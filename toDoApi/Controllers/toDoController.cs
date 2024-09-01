using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using toDoApi.Data;

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
         var allTodos =   dbContext.toDos.ToList();
            return Ok(allTodos);
        }
    }
}
