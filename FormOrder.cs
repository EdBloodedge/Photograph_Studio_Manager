using Npgsql;
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
    public partial class FormOrder : Form
    {

        int tiposesion;
        int fotos;
        string paquete;

        public FormOrder()
        {
            InitializeComponent();
            tiposesion = 0;
            dateTimePicker.MinDate = DateTime.Now.AddDays(30);
            dateTimePicker.MaxDate = DateTime.Now.AddDays(183);
            
        }

        private void buttonBoda_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Bodas “Eternizando amor” - 10,000 MXN:\r\n\nInmortaliza el día de tu boda con nuestro exclusivo paquete fotográfico por solo 10,000 pesos mexicanos. \n\nEste servicio incluye cobertura completa desde la ceremonia hasta la recepción, retratos artísticos de los novios, álbum impreso de alta calidad y archivos digitales para que puedas revivir cada momento especial de tu día inolvidable.\r\n";
            tiposesion = 1;
            paquete = "Paquete Boda";
            fotos = 60;
            pictureBox1.BackgroundImage = panelBoda.BackgroundImage;
        }

        private void buttonXV_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "XV años de Ensueño - $9,000 MXN:\r\n\nCelebra tus XV años con una sesión fotográfica que capturará la esencia de tu transición a la adultez. \n\nPor solo 9,000 pesos mexicanos, te ofrecemos una cobertura completa de la ceremonia y la fiesta, sesiones individuales y grupales, un álbum personalizado y archivos digitales de alta resolución para compartir con amigos y familiares.\r\n";
            tiposesion = 2;
            paquete = "Paquete XV";
            fotos = 50;
            pictureBox1.BackgroundImage = panelXV.BackgroundImage;
        }

        private void buttonBautizo_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Bautizo - $8,000 MXN:\r\n\nConvierte el bautizo de tu ser querido en un recuerdo perdurable con nuestro servicio fotográfico por 8,000 pesos mexicanos. \n\nIncluye fotografías documentales de la ceremonia, retratos familiares, un álbum conmemorativo y archivos digitales para que puedas revivir y compartir este evento religioso significativo.\r\n";
            tiposesion = 3;
            paquete = "Paquete Bautizo";
            fotos = 40;
            pictureBox1.BackgroundImage =panelBautizo.BackgroundImage;
        }

        private void buttonRevelacion_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Revelación de Sexo - $6,000 MXN:\r\n\nCaptura la emoción y sorpresa de la revelación de género por solo 6,000 pesos mexicanos. \n\nNuestro paquete incluye la sesión fotográfica de la revelación, imágenes creativas que capturan el momento emocionante, un álbum temático y archivos digitales para compartir la noticia con tus seres queridos.\r\n";
            tiposesion = 4;
            paquete = "Paquete Revelacion sexo";
            fotos = 50;
            pictureBox1.BackgroundImage=panelRevelacion.BackgroundImage;
        }

        private void buttonSesionFamiliar_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Sesiones Familiares - $5,000 MXN:\r\n\nCelebra el amor familiar con una sesión fotográfica por tan solo 5,000 pesos mexicanos. \n\nEste paquete incluye una sesión de fotografías en locación, imágenes espontáneas y poses planificadas, un álbum de recuerdo y archivos digitales de alta calidad para adornar tu hogar con momentos que perdurarán para siempre. ";
            tiposesion = 5;
            paquete = "Paquete Familiar";
            fotos = 40;
            pictureBox1.BackgroundImage = panelFamiliar.BackgroundImage;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
    
            string name = textBoxName.Text; 
            string number = maskedTextBoxNumber.Text;
            string date = dateTimePicker.Text;

            if(tiposesion == 0) {

                MessageBox.Show("Por favor selecciona un tipo de sesión");
                return;
            
            } else if(!maskedTextBoxNumber.MaskCompleted)
            {
                MessageBox.Show("Por favor ingresa un número de teléfono válido");
                return;

            } else if(textBoxName.Text == null)
            {
                MessageBox.Show("Por favor ingresa un nombre con el cuál dirigirnos a ti cuando te contactemos");
                return;
            }



            //Se crea la conexion llamada connectionPostgreSQL
            ConnectionPostgreSQL connectionPostgreSQL = new ConnectionPostgreSQL();

            try
            {
                using (var connection = connectionPostgreSQL.CreateConnection())
                {
                    connection.Open();

                    // Query SQL INSERT en la tabla "paquetes"
                    string consultaSql = "INSERT INTO fotografia (paquete, nombre_cliente, contacto, horario, cantidad_fotos) VALUES (@paquete, @nombre_cliente, @contacto, @horario, @fotos)";

                    using (var comando = new NpgsqlCommand(consultaSql, connection))
                    {
                        // Agregar parámetros para evitar la inyección de SQL
                        comando.Parameters.AddWithValue("@paquete", paquete);
                        comando.Parameters.AddWithValue("@nombre_cliente", textBoxName.Text);
                        comando.Parameters.AddWithValue("@contacto", maskedTextBoxNumber.Text);
                        comando.Parameters.AddWithValue("@horario", dateTimePicker.Value);
                        comando.Parameters.AddWithValue("@fotos", fotos);

                        // Ejecutar la consulta de inserción
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Sesión agendada. ¡Pronto te contactaremos!");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear la órden");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la inserción: " + ex.Message);
            }
        }
    }
 }
