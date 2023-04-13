using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccessLayer.Repositories.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        ILessonRepository LessonRepository { get; }

        ITeacherRepository teacherRepository { get;}

        int Complete();
    }
}
