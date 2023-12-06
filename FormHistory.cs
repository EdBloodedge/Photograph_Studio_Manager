using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Poyecto_estudio
{
    public partial class FormHistory : Form
    {
        bool admin;
        public FormHistory(bool admin)
        {
            InitializeComponent();
            dataGridViewOrder.Hide();
            this.admin = admin;
            if(admin) 
            {
                radioButtonAll.Visible = true;
                buttonCompleted.Visible = true;
                buttonDelete.Visible = true;
            }
        }

        //Al dar click al boton que dice BUSCAR
        private void ButtonLookUp_Click(object sender, EventArgs e)
        {

            DBaccess(0);

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DBaccess(1);
        }

        private void ButtonCompleted_Click(object sender, EventArgs e)
        {
            DBaccess(2);
        }

        private void DBaccess(int sel)
        {
            //Se crea la conexion llamada connectionPostgreSQL
            ConnectionPostgreSQL connectionPostgreSQL = new ConnectionPostgreSQL();

            using (var connection = connectionPostgreSQL.CreateConnection())
            {
                try
                {

                    string query = "";

                    //Se abre la conexion
                    connection.Open();


                    if (true) 
                    {
                        if (admin)
                        {
                            query = "SELECT id AS Orden, nombre_cliente AS Cliente, paquete AS Paquete, cantidad_fotos AS Fotos, " +
                            "sesion_enviada AS Entregado, horario AS Fecha, contacto AS Telefono FROM fotografia ";

                        }
                        else
                        {

                            query = "SELECT id AS Orden, paquete AS Paquete, cantidad_fotos AS Fotos, " +
                            "sesion_enviada AS Entregado, horario AS Fecha FROM fotografia ";
                        }


                        if (radioButtonOrderNumber.Checked)
                        {

                            //Un string que sera el query para buscar en la base de datos. Toma los datos de la tabla history cuando el numero de orden coincida con el que esta en el textbox
                            query += "WHERE id = " + textBoxOrderNumber.Text;

                        }
                        else if (radioButtonCustomerName.Checked)
                        {
                            //Un string que toma los datos de la tabla history cuando el nombre de cliente coincida
                            query += "WHERE nombre_cliente = '" + textBoxOrderNumber.Text + "'";

                        }
                        else if (radioButton1.Checked)
                        {
                            query += "WHERE contacto = '" + textBoxOrderNumber.Text + "'";
                        }
                        else if (!radioButtonAll.Checked)
                        {
                            MessageBox.Show("Por favor selecciona una opción");
                            return;
                        }

                        using (var command = new NpgsqlCommand(query, connection))
                        {

                            using (var reader = command.ExecuteReader())
                            {

                                dataGridViewOrder.Show();
                                DataTable dt = new DataTable();

                                if (reader.HasRows)
                                {  
                                    dt.Load(reader);
                                    dataGridViewOrder.DataSource = dt;

                                }
                                else
                                {
                                    dataGridViewOrder.DataSource = dt;

                                    MessageBox.Show("No se encontraron resultados.");
                                    return;
                                }

                            }

                        }

                    }

                    if (sel == 1)
                    {
                        query = "DELETE FROM fotografia ";

                        if (radioButtonOrderNumber.Checked)
                        {
                            DialogResult = MessageBox.Show("Esta acción eliminará la órden " + textBoxOrderNumber.Text + ". ¿Estás seguro de continuar?", "CUIDADO", MessageBoxButtons.YesNo);
                            query += "WHERE id = " + textBoxOrderNumber.Text;

                        }
                        else if (radioButtonCustomerName.Checked)
                        {
                            DialogResult = MessageBox.Show("Esta acción eliminará todas las órdenes para clientes con el siguiente nombre: \n" + textBoxOrderNumber.Text + ". \n\n¿Estás seguro de continuar?", "CUIDADO", MessageBoxButtons.YesNo);
                            query += "WHERE nombre_cliente = '" + textBoxOrderNumber.Text + "'";

                        }
                        else if (radioButton1.Checked)
                        {

                            DialogResult = MessageBox.Show("Esta acción eliminará todas las órdenes hechas para el teléfono:\n" + textBoxOrderNumber.Text + ". \n¿Estás seguro de continuar?", "CUIDADO", MessageBoxButtons.YesNo);
                            query += "WHERE contacto = " + textBoxOrderNumber.Text;
                        }
                        else if (radioButtonAll.Checked)
                        {
                            DialogResult = MessageBox.Show("La casilla 'Todo' está marcada. Continuar eliminará TODAS las órdenes en el sistema. \n\nEsta acción es PERMANENTE. \n\n¿Estás seguro de continuar aún así?", "CUIDADO. CASILLA 'TODO' MARCADA", MessageBoxButtons.YesNo);
                            if(DialogResult == DialogResult.Yes)
                            {
                                FormPassword formPassword = new FormPassword();
                                formPassword.ShowDialog();

                                if (!formPassword.pass)
                                {
                                    MessageBox.Show("Contraseña incorrecta.");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor selecciona una opción");
                            return;
                        }

                        if (DialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Sin cambios.");
                            return;
                        }

                        //Se crea un nuevo comando con el query y la conexion que tenemos
                        using (var command = new NpgsqlCommand(query, connection))
                        {

                            //Se crea un lector para los resultados del comando
                            using (var reader = command.ExecuteReader())
                            {
                                MessageBox.Show("Eliminación completada.");
                            }
                        }
                    }

                    if (sel == 2)
                    {
                        query = "UPDATE fotografia SET sesion_enviada = true ";

                        if (radioButtonOrderNumber.Checked)
                        {
                            DialogResult = MessageBox.Show("Esta acción marcará la órden " + textBoxOrderNumber.Text + " como completada. ¿Estás seguro de continuar?", "CUIDADO", MessageBoxButtons.YesNo);
                            query += "WHERE id = " + textBoxOrderNumber.Text;

                        }
                        else if (radioButtonCustomerName.Checked)
                        {
                            DialogResult = MessageBox.Show("Esta acción marcará como entregadas todas las órdenes para clientes con el siguiente nombre: \n\n" + textBoxOrderNumber.Text + ". \n\n¿Estás seguro de continuar?", "CUIDADO", MessageBoxButtons.YesNo);
                            query += "WHERE nombre_cliente = '" + textBoxOrderNumber.Text + "'";

                        }
                        else if (radioButton1.Checked)
                        {

                            DialogResult = MessageBox.Show("Esta acción marcará como entregadas todas las órdenes hechas para el teléfono:\n" + textBoxOrderNumber.Text + ". \n¿Estás seguro de continuar?", "CUIDADO", MessageBoxButtons.YesNo);
                            query += "WHERE contacto = " + textBoxOrderNumber.Text;
                        }
                        else if (radioButtonAll.Checked)
                        {
                            DialogResult = MessageBox.Show("La casilla 'Todo' está marcada. Continuar marcará como entregadas TODAS las órdenes en el sistema. \n\n¿Estás seguro de continuar aún así?", "CUIDADO. CASILLA 'TODO' MARCADA", MessageBoxButtons.YesNo);
                            if (DialogResult == DialogResult.Yes)
                            {
                                FormPassword formPassword = new FormPassword();
                                formPassword.ShowDialog();

                                if (!formPassword.pass)
                                {
                                    MessageBox.Show("Contraseña incorrecta.");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor selecciona una opción");
                            return;
                        }

                        if (DialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Sin cambios.");
                            return;
                        }

                        //Se crea un nuevo comando con el query y la conexion que tenemos
                        using (var command = new NpgsqlCommand(query, connection))
                        {

                            //Se crea un lector para los resultados del comando
                            using (var reader = command.ExecuteReader())
                            {
                                MessageBox.Show("Orden marcada como entregada.");
                            }
                        }
                    }



                    connection.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

    }
}
