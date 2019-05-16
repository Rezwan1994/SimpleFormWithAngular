using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA.Entity
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
    }
}
