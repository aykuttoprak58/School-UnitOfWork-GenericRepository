using Microsoft.EntityFrameworkCore;
using School.DataAccessLayer.Repositories.Abstract;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccessLayer.Repositories.Concrete
{
    public class TeacherRepository : GenericRepository<Teachers>, ITeacherRepository
    {
        public TeacherRepository(SchoolDbContext contex2) : base(contex2)
        {
        }

        public IEnumerable<Teachers> GetTopDepartments(int count)
        {
            return SchoolDbContext.Teachers.Take(count);
        }

        public SchoolDbContext SchoolDbContext { get { return context as SchoolDbContext; } }
    }
}
