using School.DataAccessLayer;
using School.DataAccessLayer.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BusinessLayer.Concrete
{
    public class TeacherBusiness : TeacherRepository
    {
        public TeacherBusiness(SchoolDbContext contex2) : base(contex2)
        {
        }
    }
}
