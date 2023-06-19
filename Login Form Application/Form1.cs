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


namespace Login_Form_Application
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ATOM\PINNACLE;Initial Catalog=Expenditure;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_LOGIN_Click(object sender, EventArgs e)
        {
        
            
            string username, user_password;

            username=txt_username.Text;
            user_password=txt_password.Text;

            try
            {
                string querry = "SELECT * FROM LOGIN_DETAILS WHERE EMPID = '" + txt_username.Text + "' AND PASSWORD = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0 )
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    // page that needed to be loaded next
                    MenuForm form2 = new MenuForm();
                    form2.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("INVALID CREDENTIALS","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_password.Clear();
                    txt_password.Clear();

                    //to focus username 
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }           
        }

        private void button_CLEAR_Click(object sender, EventArgs e)
        {
            REGISTERFORM form2 = new REGISTERFORM();
            form2.Show();
            this.Hide();
        }

        private void button_EXIT_Click(object sender, EventArgs e)
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

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                string querry = "SELECT * FROM ADMIN_DETAILS WHERE EMPID = '" + txt_username.Text + "' AND PASSWORD = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    // page that needed to be loaded next
                    Admin form2 = new Admin();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("INVALID CREDENTIALS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Clear();
                    txt_password.Clear();

                    //to focus username 
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
