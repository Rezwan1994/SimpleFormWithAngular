using SFA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA.Repository
{
    public class UserRepository : Repository<User>
    {
        DataContext context = null;
        public UserRepository(DataContext dataContext) : base(dataContext) { }
    }
}
