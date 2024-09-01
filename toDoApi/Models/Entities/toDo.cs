namespace toDoApi.Models.Entities
{
    public class toDo
    {
        public Guid Id { get; set; }
        public required string ToDoName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public required DateTime TargetDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Boolean isDone { get; set; } = false;
    }
}
