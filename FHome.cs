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
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FOrder formOrder = new FOrder();
            formOrder.ShowDialog();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FHistory formHistory = new FHistory();
            formHistory.ShowDialog();
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {
            FHistory formHistory = new FHistory();
            formHistory.ShowDialog();
        }
    }
}
