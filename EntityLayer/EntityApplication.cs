using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityApplication
    {
        private int applicationId;
        private int studentId;
        private int courseId;

        public int ApplicationId { get => applicationId; set => applicationId = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int CourseId { get => courseId; set => courseId = value; }
    }
}

