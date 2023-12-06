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
        bool admin;

        public FormHome()
        {
            InitializeComponent();
            admin = false;
            
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            FormOrder formOrder = new FormOrder(admin);
            OpenChildForm(formOrder);

        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {

            FormHistory formHistory = new FormHistory(admin);
            OpenChildForm(formHistory);
            
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {

            FormReviews formReviews = new FormReviews(admin);
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

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if(childForm != null) { childForm.Close(); }

            if (!admin)
            {
                FormPassword formPassword = new FormPassword();
                formPassword.ShowDialog();

                if (!formPassword.pass)
                {
                    MessageBox.Show("Contraseña incorrecta.");
                    return;
                }

                admin = true;
                buttonAdmin.Text = "Salir Admin";
                buttonOrder.Text = "Paquetes";
                buttonHistory.Text = "Ver ordenes";
                buttonReviews.Text = "Reseñas";
            }
            else
            {
                admin = false;
                buttonAdmin.Text = "Administrar";
                buttonOrder.Text = "Pedir una sesión";
                buttonHistory.Text = "Ver mi orden";
                buttonReviews.Text = "Danos tu opinión";
            }
        }
    }
}
