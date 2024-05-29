using Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data.Services
{
    public class UserService
    {
        ApplicationDbContext context;

        public UserService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //CREATE

        //UPDATE//

        //READ
        public Task<List<UserInfo>> GetUserInfoAsync()
        {
            List<UserInfo> result = context.userInfo.ToList();

            return Task.FromResult(result);
        }

        //DELETE

    }
}
