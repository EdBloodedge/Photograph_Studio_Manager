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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Poyecto_estudio
{

    
    public partial class FormReviews : Form
    {
        List<PictureBox> Stars = new List<PictureBox>();
        int rating;
        bool sendReview;

        public FormReviews()
        {
            InitializeComponent();
            rating = 0;
            sendReview = false;
            Stars.Add(pictureBox1Star);
            Stars.Add(pictureBox2Stars);
            Stars.Add(pictureBox3Stars);
            Stars.Add(pictureBox4Stars);
            Stars.Add(pictureBox5Stars);

            ConnectionPostgreSQL connectionPostgreSQL = new ConnectionPostgreSQL();

            using (var connection = connectionPostgreSQL.CreateConnection())
            {
                try
                {

                    string query;

                    //Se abre la conexion
                    connection.Open();

                    query = "SELECT * FROM reseñasclientes";


                    //Se crea un nuevo comando con el query y la conexion que tenemos
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        ListViewItem item;
                        //Se crea un lector para los resultados del comando
                        using (var reader = command.ExecuteReader())
                        {
                            string rate;
                            string date;
                            string review;
                            //Si el reader tiene informacion...
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    rate = reader["puntuacion"].ToString();
                                    date = reader["fecha"].ToString();
                                    review = reader["reseña"].ToString();
                                    item = new ListViewItem(new[] { rate, date, review });
                                    listView1.Items.Add(item);
                                }

                                listView1.Update();

                            }
                            else
                            {
                                MessageBox.Show("No se encontraron resultados.");
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

        private void pictureBox5Stars_Click(object sender, EventArgs e)
        {
            FillStars(5);
        }

        private void pictureBox4Stars_Click(object sender, EventArgs e)
        {
            FillStars(4);
        }

        private void pictureBox3Stars_Click(object sender, EventArgs e)
        {
            FillStars(3);
        }

        private void pictureBox2Stars_Click(object sender, EventArgs e)
        {
            FillStars(2);
        }

        private void pictureBox1Star_Click(object sender, EventArgs e)
        {
            FillStars(1);
        }

        private void FillStars(int n)
        {

            rating = n;

            for (int i = 0; i < n; i++)
            {

                Stars[i].BackgroundImage = pictureBoxLightedStar.BackgroundImage;
            }

            for (int i = 4; i >= n; i--)
            {
                Stars[i].BackgroundImage = pictureBoxTurnedOffStar.BackgroundImage;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
           
            if (textBoxReview.Text == "")
            {
                MessageBox.Show("La reseña no puede estar vacía.");
                return;
            }
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Por favor escribe un numero de orden valido");
                return;
            }
            if (rating == 0)
            {
                MessageBox.Show("Por favor elige una calificacion");
                return;
            }

            ConnectionPostgreSQL connectionPostgreSQL = new ConnectionPostgreSQL();

            using (var connection = connectionPostgreSQL.CreateConnection()) // revisar que exista la orden y no haya resena.
            {
                try
                {

                    string query;

                    //Se abre la conexion
                    connection.Open();

                    query = "SELECT * FROM fotografia WHERE id = " + numericUpDown1.Value.ToString();

                    using (var command = new NpgsqlCommand(query, connection)) //Revisar si existe la orden
                    {
                       

                        //Se crea un lector para los resultados del comando
                        using (var reader = command.ExecuteReader())
                        {

                            //Si el reader tiene informacion...
                            if (reader.HasRows)
                            {
                                sendReview = true;
                            }
                            else
                            {
                                MessageBox.Show("No se encontro el numero de orden.");
                            }

                        }


                    }
                    if (sendReview) //Revisar si la orden no cuenta ya con una resena
                    {
                        sendReview = false;
                        query = "SELECT * FROM reseñasclientes WHERE fotografia_id = " + numericUpDown1.Value.ToString();

                        using (var command = new NpgsqlCommand(query, connection)) 
                        {

                            //Se crea un lector para los resultados del comando
                            using (var reader = command.ExecuteReader())
                            {

                                //Si el reader tiene informacion...
                                if (!reader.HasRows)
                                {
                                    sendReview = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ésta orden ya cuenta con una reseña.");
                                }

                            }


                        }
                    }

                    if(sendReview) {


                        query = "INSERT INTO reseñasclientes (fotografia_id, reseña, puntuacion, fecha) VALUES (@fotoid, @review, @rate, @date)";

                        using (var comando = new NpgsqlCommand(query, connection))
                        {
                            // Agregar parámetros para evitar la inyección de SQL
                            comando.Parameters.AddWithValue("@fotoid", numericUpDown1.Value);
                            comando.Parameters.AddWithValue("@review", textBoxReview.Text);
                            comando.Parameters.AddWithValue("@rate", rating);
                            comando.Parameters.AddWithValue("@date", DateTime.Now);


                            // Ejecutar la consulta de inserción
                            int filasAfectadas = comando.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("¡Muchas gracias por compartir tu opinión!");
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error al crear la reseña.");
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

            sendReview = false;

        }
    }
}
