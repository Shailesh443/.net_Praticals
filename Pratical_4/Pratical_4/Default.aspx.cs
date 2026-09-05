using System;
using System.Web.UI;

namespace Pratical_4
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" ||
                TextBox2.Text == "" ||
                TextBox3.Text == "" ||
                TextBox4.Text == "")
            {
                Label11.ForeColor = System.Drawing.Color.Red;
                Label11.Text = "Please fill all required fields.";
                return;
            }

            Label11.ForeColor = System.Drawing.Color.Green;
            Label11.Text = "Registration Successful!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";

            DropDownList1.SelectedIndex = 0;

            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            RadioButton5.Checked = false;
            RadioButton6.Checked = false;

            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;

            Label11.Text = "";
        }
    }
}