using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccessLayer.Repositories.Abstract
{
    public interface ILessonRepository:IGenericRepository<Lessons>
    {
        IEnumerable<Lessons> GetTopDepartments(int count);
    }
}
