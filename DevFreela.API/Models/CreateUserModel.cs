using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Models
{
    public class CreateUserModel
    {
        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string Email { get; set; }
    }
}
