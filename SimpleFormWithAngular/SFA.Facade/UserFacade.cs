using SFA.Entity;
using SFA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFA.Facade
{
    public class UserFacade : Facade<User>
    {
        UserRepository userRepository = null;
        public UserFacade(DataContext dataContext) : base(dataContext)
        {
            userRepository = new UserRepository(dataContext);
        }
    }
}
