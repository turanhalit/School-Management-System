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
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityStudent> StList = BLLStudent.ListStudentBLL();
            Repeater1.DataSource = StList;
            Repeater1.DataBind();
        }
    }
}