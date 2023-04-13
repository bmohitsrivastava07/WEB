using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.InterfaceD
{
    public interface Interface_D_Todolist
    {
        public List<Todolist> Get();
        public Todolist Post(Todolist todolist);
        public string Put(Todolist todolist);
        public string Delete(string id);
    }
}
