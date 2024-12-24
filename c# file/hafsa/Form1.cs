using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Crp.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Crp.Value += 1;
            Crp.Text = Crp.Value.ToString();
            if(Crp.Value ==100)
            {
                timer1.Stop();
                login l = new login();
                this.Hide();
                l.Show();
            }
        }
    }
}
