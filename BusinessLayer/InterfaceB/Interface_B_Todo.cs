using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.InterfaceB
{
    public interface Interface_B_Todo
    {
        public List<string> Get();
        public string Post(ProfileModel todoModel);
    }
}
