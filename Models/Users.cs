using System;

public class User
{
    public int UserID { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required UserRole RoleName { get; set; }

    public virtual ICollection<Project> ManagedProjects { get; set; }
}

public enum UserRole
{
    Administrator,  // Адміністратор
    ProjectManager, // Менеджер проекту
    Employee        // Співробітник
}