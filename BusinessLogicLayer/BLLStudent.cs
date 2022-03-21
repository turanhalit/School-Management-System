using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLStudent
    {
        public static int AddStudentBLL(EntityStudent p)
        {
            if (p.Name != null && p.Surname !=null && p.Number != null && p.Photo != null && p.Password != null)
            {
                return DALStudent.AddStudent(p);
            }
            return -1;
        }

        public static List<EntityStudent> ListStudentBLL()
        {

            return DALStudent.StudentList();
            
        }

        public static bool DeleteStudentBLL(int parameter)
        {
            if ( parameter>=0)
            {
                return DALStudent.DeleteStudent(parameter);
            }
            return false;
        }
        public static List<EntityStudent> StudenDetailstBLL(int parameter)
        {

            return DALStudent.StudentDetails(parameter);

        }

        public static bool UptadeStudentBLL(EntityStudent p)
        {
            if (p.Name != null && p.Surname != null && p.Number != null && p.Photo != null && p.Password != null && p.Id>0)
            {
                return DALStudent.UpdateStudent(p);
            }
            return false;
        }

    }
}
