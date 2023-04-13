using DatabaseLayer.Context;
using DatabaseLayer.InterfaceD;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Linq;

namespace DatabaseLayer
{
    public class ProfileOperation:Interface_D_Todo
    {
        private readonly TodolistDbContext _context;
        public ProfileOperation(TodolistDbContext context)
        {
            _context = context;
        }
        public List<string> Get()
        {
            List<string> profile = new List<string>();  
            foreach (var item in _context.Profiles)
            {
                profile.Add(item.Email);
            }
            return profile;
        }

        public string Post(Profile todo)
        {
            _context.Profiles.Add(todo);
            _context.SaveChanges();
            return "Inserted";
        }
    }
}