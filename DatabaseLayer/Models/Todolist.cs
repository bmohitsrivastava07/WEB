using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer.Models;

public partial class Todolist
{
    [Key]
    public string TodoId { get; set; } = null!;

    public string? TodoDescription { get; set; }

    public string? TodoStatus { get; set; }

    public string ProfileId { get; set; }

    public virtual Profile? ProfileIdTodoNavigation { get; set; }
}
