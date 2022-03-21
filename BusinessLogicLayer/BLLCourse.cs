using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLCourse
    {
        public static List<EntityCourse> ListCourseBLL()
        {

            return DALCourse.CourseList();

        }
        public static int AddRequestBLL(EntityApplication app)
        {
            if (app.StudentId != null && app.CourseId!=null)
            {
                return DALCourse.AddRequest(app);
            }
            return -1;
        }
    }
}
