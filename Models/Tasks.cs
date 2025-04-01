using System;

public class Task
{
    public required int TaskID { get; set; }
    public required int ProjectID { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required int AssigneeId { get; set; }
    public required TaskStatus Status { get; set; }
    public required DateTime CreationDate { get; set; }
    public required DateTime DueDate { get; set; }

    public required virtual Project Project { get; set; }
    public required virtual User Assignee { get; set; }
}

public enum TaskStatus
{
    ToDo,        // До виконання
    InProgress,  // В процесі
    Done,        // Виконано
    Blocked      // Заблоковано
}