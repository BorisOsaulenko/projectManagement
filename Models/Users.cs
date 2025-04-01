using System;

public class User
{
	public int UserID { get; set; }
	public string Username { get; set; }
	public string Password { get; set; }
	public UserRole RoleName { get; set; }

	public virtual UserRole Role { get; set; }
    public virtual ICollection<Project> ManagedProjects { get; set; }
}

public enum UserRole
{
    Administrator,  // Адміністратор
    ProjectManager, // Менеджер проекту
    Employee        // Співробітник
}