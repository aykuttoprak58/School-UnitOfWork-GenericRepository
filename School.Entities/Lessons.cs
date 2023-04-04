using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Lessons
    {
        [Key]
        public int LessonId { get; set; }

        public string LessonName { get; set; }

        public int LessonLevel { get; set; }    
        
        ICollection<Teachers> Teachers { get; set; }    

    }
}
