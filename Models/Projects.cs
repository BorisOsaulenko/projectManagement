using System;

public class Project
{
	public int PrijectID { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime DeadLine { get; set; }
	public ProjectStatus Status { get; set; }
    public int ManagerID { get; set; }

    public virtual User Manager { get; set; }
    public virtual ICollection<Task> Tasks { get; set; }
}

public enum ProjectStatus
{
    NotStarted,  // Не розпочато
    InProgress,  // Виконується
    Completed,   // Завершено
    OnHold       // Призупинено
}
