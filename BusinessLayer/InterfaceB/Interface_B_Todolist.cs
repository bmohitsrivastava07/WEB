using BusinessLayer.Models;
using BusinessLayer.OutputModels;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.InterfaceB
{
    public interface Interface_B_Todolist
    {
        public List<Outputlist> Get();
        public TodolistModel Post(TodolistModel todolistModel);
        public string Put(TodolistModel todolistModel);
        public string Delete(string id);
    }
}
