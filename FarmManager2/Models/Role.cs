using System.Collections.Generic;

namespace FarmManager2.Models;

public class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;          // например "Администратор", "Менеджер", "Оператор"
    public string Login { get; set; } = null!;         // уникальный логин для входа

    // Хэш пароля (BCrypt). Плейнтекстовый пароль НИКОГДА не храним!
    public string PasswordHash { get; set; } = null!;

    // Навигационное свойство: все пользователи с этой ролью
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}