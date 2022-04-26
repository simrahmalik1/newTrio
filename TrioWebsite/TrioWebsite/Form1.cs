using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrioWebsite
{
    public partial class Form1 : Form
    {
        SqlConnection c = new SqlConnection("Data Source=CSSERVER2; Initial Catalog=colojc7; User Id=colojc7; Password=1020997334;");

        public Form1()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into STUDENT values('"+txtRamID.Text+"','"+txtFirstName.Text+"','"+txtLastName.Text+"','"+txtMajor.Text+ "','" + txtStanding.Text + "','" + txtCurrentGPA.Text + "','" + txtEmail.Text + "','" + txtPhoneNumber.Text + "','" + txtHomeAddress.Text + "','" + txtStudentStatus.Text + "')", c);
            cmd.ExecuteNonQuery();
            lblMessage.Text = "Record submitted successfully!";
            c.Close();
        }

        private void LblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
