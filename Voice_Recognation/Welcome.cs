using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voice_Recognation
{
    public partial class Welcome : Form
    {
        public static string userName = string.Empty;
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text;
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
