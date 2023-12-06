using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poyecto_estudio
{
    public partial class FormPassword : Form
    {

        public bool pass;
        public FormPassword()
        {
            InitializeComponent();
            pass = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
                pass = true;

            this.Close();
        }
    }
}
