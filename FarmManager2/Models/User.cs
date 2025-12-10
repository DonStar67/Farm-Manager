namespace FarmManager2.Models;

public class User
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Lastname { get; set; }              // отчество может быть null

    // Телефон — всегда строка!
    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    // Внешний ключ и навигация
    public int RoleId { get; set; }

    // virtual — обязательно для lazy/proxy в EF Core
    public virtual Role Role { get; set; } = null!;
}