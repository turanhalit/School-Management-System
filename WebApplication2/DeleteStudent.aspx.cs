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
    public partial class DeleteStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            Response.Write(x);

            EntityCourse ent = new EntityCourse();
            ent.Id = x;
            BLLStudent.DeleteStudentBLL(ent.Id);
            Response.Redirect("StudentList.aspx");
        }
    }
}