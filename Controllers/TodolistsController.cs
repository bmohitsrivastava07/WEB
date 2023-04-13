using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseLayer.Context;
using DatabaseLayer.Models;
using BusinessLayer.InterfaceB;
using BusinessLayer.Models;
using BusinessLayer.OutputModels;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodolistsController : ControllerBase
    {
        private readonly Interface_B_Todolist Todolist_obj;
        public TodolistsController(Interface_B_Todolist obji)
        {
            Todolist_obj = obji;
        }
        [HttpGet]
        public List<Outputlist> GetTodolists()
        {
            return Todolist_obj.Get();
        }
        [HttpPost]
        public TodolistModel PostTodolist([FromBody] TodolistModel res)
        {
            return Todolist_obj.Post(res); 
        }
        [HttpPut]
        public string PutTodolist([FromBody] TodolistModel res)
        {
            return Todolist_obj.Put(res);
        }
        [HttpDelete]
        public string DeleteTodolist(string id)
        {
            return Todolist_obj.Delete(id);
        }
    }
}
