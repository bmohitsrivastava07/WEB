using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.InterfaceD
{
    public interface Interface_D_Todo
    {
        public List<string> Get();
        public string Post(Profile todo);
    }
}
