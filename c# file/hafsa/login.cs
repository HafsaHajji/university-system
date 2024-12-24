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

namespace hafsa
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=HAFSA;Initial Catalog=Emsystem;Integrated Security=True");
            string query = "select * from login where username ='" + txtuser.Text + "'and password ='" + txtpass.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                //MessageBox.Show("Correct User and Password");
                dashboard d = new dashboard();
                this.Hide();
                d.Show();
            }
            else
            {
                MessageBox.Show("Incorrect User and password");
            }
        }

    }
}
