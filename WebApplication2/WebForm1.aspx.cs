using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityStudent st = new EntityStudent();
            st.Name = TextName.Text;
            st.Surname = TextSurname.Text;
            st.Number = TextNumber.Text;
            st.Password = TextPassword.Text;
            st.Photo = TextPhoto.Text;
            BLLStudent.AddStudentBLL(st);
        }


    }
}