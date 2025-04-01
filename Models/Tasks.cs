using System;

public class Task
{
	public int TaskID { get; set; }
    public int ProjectID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int AssignadTo { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime DueDate { get; set; }

    public virtual Project Project { get; set; }
    public virtual User Assignee { get; set; }
}

public enum TaskStatus
{
    ToDo,        // До виконання
    InProgress,  // В процесі
    Done,        // Виконано
    Blocked      // Заблоковано
}