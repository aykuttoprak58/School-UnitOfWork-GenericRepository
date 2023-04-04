﻿using School.DataAccessLayer.Repositories.Abstract;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccessLayer.Repositories.Concrete
{
    public class LessonRepository : GenericRepository<Lessons>, ILessonRepository
    {
        public LessonRepository(SchoolDbContext contex2) : base(contex2)
        {
        }

        public IEnumerable<Lessons> GetTopDepartments(int count)
        {
            return SchoolDbContext.Lessons.Take(count); 
        }

        public SchoolDbContext SchoolDbContext { get { return context as SchoolDbContext;}}    



    }
}
