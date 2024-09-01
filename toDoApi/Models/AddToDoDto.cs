namespace toDoApi.Models
{
    public class AddToDoDto
    {
        public required string ToDoName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public required DateTime TargetDate { get; set; }
        public required Int32 toDoNo { get; set; }
    }
}
