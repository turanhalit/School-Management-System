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
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityCourse> entityCourses = BLLCourse.ListCourseBLL();
                DropDownList1.DataSource = BLLCourse.ListCourseBLL();
                DropDownList1.DataTextField = "CourseName";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityApplication app = new EntityApplication();
            app.StudentId = int.Parse(TextBox1.Text);
            app.CourseId = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLCourse.AddRequestBLL(app);
        }
    }
}