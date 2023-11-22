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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory();
            formHistory.ShowDialog();
        }
    }
}
