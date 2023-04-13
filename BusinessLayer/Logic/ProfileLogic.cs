using BusinessLayer.InterfaceB;
using BusinessLayer.Models;
using DatabaseLayer.InterfaceD;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Logic
{
    public class ProfileLogic : Interface_B_Todo
    {
        public readonly Interface_D_Todo interface_D;
        public ProfileLogic(Interface_D_Todo interfaceD) {
            interface_D = interfaceD;
        }
        public List<string> Get()
        {
            return interface_D.Get();
        }

        public string Post(ProfileModel todoModel)
        {
            var res = new Profile
            {
                Id = todoModel.Id,
                Name = todoModel.Name,
                Email = todoModel.Email,
                Age = todoModel.Age,
                PhoneNumber = todoModel.PhoneNumber,
            };
            return interface_D.Post(res);
        }
    }
}
