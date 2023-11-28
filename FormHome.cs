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
        Form childForm;

        public FormHome()
        {
            InitializeComponent();
            
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            OpenChildForm(formOrder);

        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {

            FormHistory formHistory = new FormHistory();
            OpenChildForm(formHistory);
            
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {

            FormReviews formReviews = new FormReviews();
            OpenChildForm(formReviews);
        }

        private void OpenChildForm(Form cf)
        {

            if(childForm != null)
            {
                childForm.Close();
            }

            childForm = cf;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront(); 
            childForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAboutUs formAboutUs = new FormAboutUs();
            OpenChildForm(formAboutUs);
        }
    }
}
