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
using System.Security.Cryptography;

namespace Login_Form_Application
{
    public partial class REGISTERFORM : Form
    {
        public REGISTERFORM()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ATOM\\PINNACLE;Initial Catalog=Expenditure;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO LOGIN_DETAILS VALUES (@EMPID,@PASSWORD,@FNAME,@MNAME,@SNAME,@GENDER,@DOB,@CONTACT)", con);
            cmd.Parameters.AddWithValue("@EMPID", txt_EMPID.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", txt_PASSWORD.Text);
            cmd.Parameters.AddWithValue("@FNAME", txt_FNAME.Text);
            cmd.Parameters.AddWithValue("@MNAME", txt_MNAME.Text);
            cmd.Parameters.AddWithValue("@SNAME", txt_SNAME.Text);
            cmd.Parameters.AddWithValue("@GENDER", lb_GENDER.Text);
            cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(dt_DOB.Text));
            cmd.Parameters.AddWithValue("@CONTACT", txt_CONTACT.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("EMPLOYEE REGISTERED");
                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN form2 = new LOGIN();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
