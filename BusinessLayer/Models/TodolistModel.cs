using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class TodolistModel
    {
        public string TodoId { get; set; } = null!;

        public string? TodoDescription { get; set; }

        public string? TodoStatus { get; set; }

        public string ProfileId { get; set; }
    }
}
