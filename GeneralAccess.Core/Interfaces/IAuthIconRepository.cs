using GeneralAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeneralAccess.Core.Interfaces
{
    public interface IAuthIconRepository
    {
        Task<IEnumerable<AuthIcon>> GetAllAuthIconsAsync();
        void AddAuthIcon(AuthIcon authIcon);

    }
}
