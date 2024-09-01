namespace toDoApi.Models.Entities
{
    public class toDo
    {
        public Guid Id { get; set; }
        public required string ToDoName { get; set; }

    }
}
