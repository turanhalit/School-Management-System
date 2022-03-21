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
    public partial class UpdateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"].ToString());
            TextId.Text = x.ToString();
            TextId.Enabled = false;

            if (Page.IsPostBack== false)
            {
                List<EntityStudent> StudentList = BLLStudent.StudenDetailstBLL(x);
                TextName.Text = StudentList[0].Name;
                TextSurname.Text = StudentList[0].Surname;
                TextNumber.Text = StudentList[0].Number;
                TextPhoto.Text = StudentList[0].Photo;
                TextPassword.Text = StudentList[0].Password;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityStudent ent = new EntityStudent();
            ent.Name = TextName.Text;
            ent.Surname = TextSurname.Text;
            ent.Number = TextNumber.Text;
            ent.Password = TextPassword.Text;
            ent.Photo = TextPhoto.Text;
            ent.Id = Convert.ToInt32(TextId.Text);
            BLLStudent.UptadeStudentBLL(ent);
            Response.Redirect("StudentList.aspx");


        }
    }
}