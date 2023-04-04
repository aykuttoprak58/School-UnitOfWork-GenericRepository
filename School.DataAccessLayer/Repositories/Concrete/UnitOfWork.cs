using School.DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccessLayer.Repositories.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private SchoolDbContext dbContext;

        public UnitOfWork(SchoolDbContext dbContext2)
        {
            dbContext = dbContext2;
            LessonRepository = new LessonRepository(dbContext);   
            teacherRepository = new TeacherRepository(dbContext);       
        }

        public ILessonRepository LessonRepository { get; private set; } 

        public ITeacherRepository teacherRepository { get; private set; }       

        public int Complete()
        {
           return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
