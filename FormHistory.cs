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
            }
        }

        //Al dar click al boton que dice BUSCAR
        private void buttonLookUp_Click(object sender, EventArgs e)
        {

            //Se crea la conexion llamada connectionPostgreSQL
            ConnectionPostgreSQL connectionPostgreSQL = new ConnectionPostgreSQL();

            using(var connection = connectionPostgreSQL.CreateConnection())
            {
                try
                {

                    string query;

                    //Se abre la conexion
                    connection.Open();

                    if (admin)
                    {
                        query = "SELECT id AS Orden, nombre_cliente AS Cliente, paquete AS Paquete, cantidad_fotos AS Fotos, " +
                        "sesion_enviada AS Entregado, horario AS Fecha, contacto AS Telefono FROM fotografia ";

                    } else
                    {
                        
                        query = "SELECT id AS Orden, paquete AS Paquete, cantidad_fotos AS Fotos, " +
                        "sesion_enviada AS Entregado, horario AS Fecha FROM fotografia ";
                    }
            

                    if (radioButtonOrderNumber.Checked)
                    {

                        //Un string que sera el query para buscar en la base de datos. Toma los datos de la tabla history cuando el numero de orden coincida con el que esta en el textbox
                        query += "WHERE id = " + textBoxOrderNumber.Text;

                    }
                    else if(radioButtonCustomerName.Checked) 
                    { 
                        //Un string que toma los datos de la tabla history cuando el nombre de cliente coincida
                        query += "WHERE nombre_cliente = '" + textBoxOrderNumber.Text + "'";

                    }
                    else if (radioButton1.Checked)
                    {
                        query += "WHERE contacto = '" + textBoxOrderNumber.Text + "'";
                    }
                    else if(!radioButtonAll.Checked)
                    {
                        MessageBox.Show("Por favor selecciona una opción");
                        return;
                    }
                        

                    //Se crea un nuevo comando con el query y la conexion que tenemos
                    using (var command = new NpgsqlCommand(query, connection))
                    {

                        //Se crea un lector para los resultados del comando
                        using (var reader = command.ExecuteReader())
                        {

                            //Si el reader tiene informacion...
                            if (reader.HasRows)
                            {
                                dataGridViewOrder.Show();
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                dataGridViewOrder.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron resultados.");
                            }

                        }


                    }

                    connection.Close();

                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }
    }
}
