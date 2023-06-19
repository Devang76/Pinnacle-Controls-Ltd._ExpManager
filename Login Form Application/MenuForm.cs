using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form_Application
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_CLEAR_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ATOM\\PINNACLE;Initial Catalog=Expenditure;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO EXP_DETAILS VALUES (@EMPID,@EXPID,@EXPDATE,@EXPCAT,@EXPAMT,@METHOD,@VENDOR,@DESC,@RECPT,@STS,@APRDATE,@ETRDATE)", con);
            cmd1.Parameters.AddWithValue("@EMPID", txt_EMPID.Text);
            cmd1.Parameters.AddWithValue("@EXPID", txt_EXPID.Text);
            cmd1.Parameters.AddWithValue("@EXPDATE", DateTime.Parse(dt_EXPDATE.Text));
            cmd1.Parameters.AddWithValue("@EXPCAT", txt_CATEGORY.Text);
            cmd1.Parameters.AddWithValue("@EXPAMT", int.Parse(txt_AMT.Text));
            cmd1.Parameters.AddWithValue("@METHOD", cb_METHOD.Text);
            cmd1.Parameters.AddWithValue("@VENDOR", txt_VENDOR.Text);
            cmd1.Parameters.AddWithValue("@DESC", txt_DESCRIPTION.Text);
            cmd1.Parameters.AddWithValue("@RECPT", txt_RCPTID.Text);
            cmd1.Parameters.AddWithValue("@STS", lb_STS.Text);
            cmd1.Parameters.AddWithValue("APRDATE", DateTime.Parse(dt_APR.Text));
            cmd1.Parameters.AddWithValue("@ETRDATE", DateTime.Parse(dt_ENTRY.Text));
            cmd1.ExecuteNonQuery();
            MessageBox.Show("EXPENDITURE FEEDED");
            con.Close();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ATOM\\PINNACLE;Initial Catalog=Expenditure;Integrated Security=True");
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT STATUS, APRVL_DATE FROM EXP_DETAILS WHERE EMPID = @EMPID OR EXPID = @EXPID", con);
            cmd2.Parameters.AddWithValue("@EMPID", txt_EMPID.Text);
            cmd2.Parameters.AddWithValue("@EXPID", txt_EXPID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_DATABASE.DataSource = dt;
            cmd2.ExecuteNonQuery();
            con.Close();

            DialogResult res;
            res = MessageBox.Show("Checking Completed ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }


        }
    }
}
