using BusinessLayer.InterfaceB;
using BusinessLayer.Models;
using BusinessLayer.OutputModels;
using DatabaseLayer.InterfaceD;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Logic
{
    public class TodolistLogic : Interface_B_Todolist
    {
        public readonly Interface_D_Todolist interface_obj;
        public TodolistLogic(Interface_D_Todolist obj)
        {
            interface_obj = obj;
        }
        public List<Outputlist> Get()
        {
            var ans = interface_obj.Get();
            var res = new List<Outputlist>();
            foreach(var item in ans)
            {
                res.Add(new Outputlist
                {
                    Todoid = item.TodoId,
                    TodoDescription = item.TodoDescription,
                    TodoStatus = item.TodoStatus
                });
            }
            return res; 
        }
        public TodolistModel Post(TodolistModel res)
        {
            var todolistModel = new Todolist()
            {
                TodoId= res.TodoId,
                TodoDescription= res.TodoDescription,
                TodoStatus= res.TodoStatus,
                ProfileId= res.ProfileId,
            };
            interface_obj.Post(todolistModel);
            return res;
        }
        public string Put(TodolistModel res)
        {
            var updatelist = new Todolist()
            {
                TodoId= res.TodoId,
                TodoDescription = res.TodoDescription,
                TodoStatus = res.TodoStatus,
                ProfileId = res.ProfileId,
            };
            return interface_obj.Put(updatelist);
        }
        public string Delete(string res)
        {
            return interface_obj.Delete(res);
        }
    }
}
