using BlogifyHub.Entities.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyHub.Service.IServices
{
    public interface ITokenManagerService
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
