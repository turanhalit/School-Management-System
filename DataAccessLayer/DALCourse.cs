using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALCourse
    {
        public static List<EntityCourse> CourseList()
        {
            List<EntityCourse> courses = new List<EntityCourse>();
            SqlCommand command2 = new SqlCommand("select * from Tbl_lesson ", Connection.con);

            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }

            SqlDataReader dr = command2.ExecuteReader();

            while (dr.Read())
            {
                EntityCourse c = new EntityCourse();
                c.Id = Convert.ToInt32(dr["Lesson_Id"].ToString());
                c.CourseName = (dr["Lesson_name"].ToString());
                c.Max = int.Parse(dr["Lesson_maxlimit"].ToString());
                c.Min = int.Parse(dr["Lesson_minlimit"].ToString());

                courses.Add(c);
            }
            dr.Close();
            return courses;
        }

        public static int AddRequest(EntityApplication app)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_application(Student_id,Lesson_id) values(@p1,@p2)",Connection.con);
            command.Parameters.AddWithValue("@P1", app.StudentId);
            command.Parameters.AddWithValue("@P2", app.CourseId);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            return command.ExecuteNonQuery();
        }

    }
}
