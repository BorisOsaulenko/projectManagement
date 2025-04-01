using System;

public class Project
{
    public required int PrijectID { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required DateTime CreationDate { get; set; }
    public required DateTime DeadLine { get; set; }
    public required ProjectStatus Status { get; set; }
    public required int ManagerID { get; set; }

    public required virtual User Manager { get; set; }
    public required virtual ICollection<Task> Tasks { get; set; }
}

public enum ProjectStatus
{
    NotStarted,  // Не розпочато
    InProgress,  // Виконується
    Completed,   // Завершено
    OnHold       // Призупинено
}
