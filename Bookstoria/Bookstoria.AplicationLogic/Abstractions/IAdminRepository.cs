using Bookworms.AplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookworms.AplicationLogic.Abstractions
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Admin GetAdminByUserID(Guid userID);
    }
}
