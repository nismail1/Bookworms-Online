using Bookworms.AplicationLogic.Abstractions;
using Bookworms.AplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookworms.EFDataAccess
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(BookwormsDbContext dbContext) : base(dbContext)
        {

        }
        public Admin GetAdminByUserID(Guid id)
        {
            return dbContext.Admins
                            .Where(admin => admin.UserID == id)
                            .SingleOrDefault();
        }
    }
}
