using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Teachers
    {
        [Key]
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }

        public string TeacherTitle { get; set;}
        
        public int TeacherAge { get; set; }

        public int TeacherBudget { get; set; }
        [ForeignKey("Lessons")]
        public int LessonId { get; set; }

        private Lessons Lessons { get; set; }        
    }
}
