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
    public class DALStudent
    {
        public static int AddStudent(EntityStudent s)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_student " +
                "(Student_Name,Student_Surname,Student_Number,Student_Photo,Student_Password) values (@p1,@p2,@p3,@p4,@p5)", Connection.con);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@p1", s.Name);
            command.Parameters.AddWithValue("@p2", s.Surname);
            command.Parameters.AddWithValue("@p3", s.Number);
            command.Parameters.AddWithValue("@p4", s.Photo);
            command.Parameters.AddWithValue("@p5", s.Password);
            //command.Parameters.AddWithValue("@p6", s.Balance);

            return command.ExecuteNonQuery();
        }

        public static List<EntityStudent> StudentList()
        {
            List<EntityStudent> students = new List<EntityStudent>();
            SqlCommand command2 = new SqlCommand("select * from Tbl_student " ,Connection.con);

            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }

            SqlDataReader dr = command2.ExecuteReader();

            while (dr.Read())
            {
                EntityStudent st = new EntityStudent();
                st.Id = Convert.ToInt32(dr["Student_Id"].ToString());
                st.Name = (dr["Student_Name"].ToString());
                st.Surname = (dr["Student_Surname"].ToString());
                st.Number = (dr["Student_Number"].ToString());
                st.Photo = (dr["Student_Photo"].ToString());
                st.Password = (dr["Student_Password"].ToString());
                st.Balance = Convert.ToDouble(dr["Student_Balance"].ToString());

                students.Add(st);
            }
            dr.Close();
            return students;
        }

        public static bool DeleteStudent(int parameter)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_student where Student_Id=@P1", Connection.con);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", parameter);
            return command.ExecuteNonQuery() > 0;
        }

        public static List<EntityStudent> StudentDetails(int id)
        {
            List<EntityStudent> students = new List<EntityStudent>();
            SqlCommand command = new SqlCommand("select * from Tbl_student where Student_Id=@P1 ", Connection.con);
            command.Parameters.AddWithValue("@P1", id);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                EntityStudent st = new EntityStudent();
                st.Id = Convert.ToInt32(dr["Student_Id"].ToString());
                st.Name = (dr["Student_Name"].ToString());
                st.Surname = (dr["Student_Surname"].ToString());
                st.Number = (dr["Student_Number"].ToString());
                st.Photo = (dr["Student_Photo"].ToString());
                st.Password = (dr["Student_Password"].ToString());
                st.Balance = Convert.ToDouble(dr["Student_Balance"].ToString());

                students.Add(st);
            }
            dr.Close();
            return students;
        }

        public static bool UpdateStudent(EntityStudent st)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Student set Student_Name=@P1,Student_Surname=@P2,Student_Number=@P3,Student_Photo=@P4,Student_Password=@P5 WHERE Student_Id=@P6", Connection.con);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@P1", st.Name);
            command.Parameters.AddWithValue("@P2", st.Surname);
            command.Parameters.AddWithValue("@P3", st.Number);
            command.Parameters.AddWithValue("@P4", st.Photo);
            command.Parameters.AddWithValue("@P5", st.Password);
            command.Parameters.AddWithValue("@P6", st.Id);

            return command.ExecuteNonQuery() > 0;
        }
    }
}
