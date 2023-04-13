using DatabaseLayer.Context;
using DatabaseLayer.InterfaceD;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Operations
{
    public class TodolistOperation:Interface_D_Todolist
    {
        private readonly TodolistDbContext _context;

        public TodolistOperation()
        {
        }
        public TodolistOperation(TodolistDbContext context)
        {
            _context = context;
        }
        public List<Todolist> Get()
        {
            return _context.Todolists.ToList();
        }
        public Todolist Post(Todolist todolist)
        {
            using(var context=_context)
            {
            context.Todolists.Add(todolist);
            context.SaveChanges();
            }
            return todolist;
        }
        public string Put(Todolist todolist)
        {
            using(var context = _context)
            {
                var id = context.Todolists.Find(todolist.TodoId);
                if (id != null)
                {
                    id.TodoDescription = todolist.TodoDescription;
                    id.TodoStatus = todolist.TodoStatus;
                    id.ProfileId = todolist.ProfileId;
                    context.SaveChanges();
                }
            }
            return "Updated";
        }
        public string Delete(string id)
        {
            using(var context = _context)
            {
                var item = context.Todolists.Where(x=>x.TodoId == id).FirstOrDefault();
                context.Todolists.Remove(item);
                context.SaveChanges();
            }
            return "Deleted";
        }
    }
}
