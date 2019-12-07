using GeneralAccess.Core.Database;
using GeneralAccess.Core.Interfaces;
using GeneralAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeneralAccess.Framework.Repositories
{
    public class AuthIconRepository : IAuthIconRepository
    {
        private readonly MyContext myContext;

        public AuthIconRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }


        public async Task<IEnumerable<AuthIcon>> GetAllAuthIconsAsync()
        {
            return await myContext.AuthIcons.ToListAsync();
        }

        public void AddAuthIcon(AuthIcon authIcon)
        {
            myContext.AuthIcons.Add(authIcon);
        }
    }
}
