using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer.Models;

public partial class Profile
{
    [Key]
    public string Id { get; set; }
    public string Email { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Todolist> Todolists { get; } = new List<Todolist>();
}
