using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class ProfileModel
    {
        public string Id { get; set; }
        public string Email { get; set; } = null!;

        public string Name { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }
    }
}
