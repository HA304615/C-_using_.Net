using System;

namespace PageEvents
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            string gender = DropDownList1.SelectedItem.Text;
            string Name = TextBox1.Text;
            Label3.Text = "Name is " + Name + "and gender is " + gender;
        }
    }
}