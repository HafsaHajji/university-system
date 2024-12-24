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

namespace hafsa
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HAFSA;Initial Catalog=Emsystem;Integrated Security=True");
        private void showtable()
        {
            string query= " Select * from  Reg";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder blder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
           

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
           if (txtEname.Text == ""|| txttell.Text == "" || txtaddress.Text == "" )
            {
                MessageBox.Show("Fill The Blank Feilds");
            }
           else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Reg(EmpName , Tell , Adress , Degree, DOJ, Title) Values (@Emname, @Tell, @Add, @Deg ,@DOJ, @Title)", conn);
                    cmd.Parameters.AddWithValue("@EmName", txtEname.Text);
                    cmd.Parameters.AddWithValue("@Tell", txttell.Text);
                    cmd.Parameters.AddWithValue("@Add", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@Deg", comboDeg.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DOJ", Doj.Value.Date);
                    cmd.Parameters.AddWithValue("@Title", comboTitle.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Has been Saved");
                    conn.Close();
                    showtable();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
                
           
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emsystemDataSet.Reg' table. You can move, or remove it, as needed.
            this.regTableAdapter.Fill(this.emsystemDataSet.Reg);

        }
    }
}
