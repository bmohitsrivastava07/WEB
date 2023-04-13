using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseLayer.Context;
using DatabaseLayer.Models;
using BusinessLayer;
using BusinessLayer.InterfaceB;
using BusinessLayer.Models;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly Interface_B_Todo Todo_Obj;
        public ProfileController(Interface_B_Todo obj) {
            Todo_Obj = obj;
        }
        [HttpGet]
        public List<string> GetTodos()
        {
            return Todo_Obj.Get();
        }
        [HttpPost]
        public string PostTodo([FromBody] ProfileModel res)
        {
            return Todo_Obj.Post(res);
        }
    }
}
