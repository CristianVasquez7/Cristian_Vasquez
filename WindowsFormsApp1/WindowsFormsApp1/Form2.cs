using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    origen.CommandText = "INSERT INTO Cliente(Nombre, 1er apellido, 2do apellido, Nit, Fecha de nacimiento) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', " + textBox4.Text + "', '" + textBox5.Text + "', " + textBox6.Text + ");";
                    origen.Connection = Coneccion;
                    Coneccion.Open();
                    origen.ExecuteNonQuery();
                    origen.CommandText = "SELECT @@Identity";
                    Coneccion.Close();
                    MessageBox.Show("Has ingresado los datos correctamente");
                    limpiar();
                    llenarGrid();




                }
                catch (Exception ex)
                {
                    MessageBox.Show($"se ha producido un error {ex}");
                }

            }
            else MessageBox.Show("Los campos no deben quedar vacios.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox2.Text != "" && textBox6.Text != "")
            {
                try
                {
                    origen.CommandText = "UPDATE Cliente SET Nombre = '" + textBox1.Text + "', 1er apellido = '" + textBox2.Text + "', 2do apellido = '" + textBox3.Text + "', Nit = '" + textBox4.Text + "', Fecha de nacimiento = " + textBox6.Text + " WHERE Id_cliente = " + codigo.ToString();

                    origen.Connection = Coneccion;
                    Coneccion.Open();
                    origen.ExecuteNonQuery();
                    Coneccion.Close();
                    MessageBox.Show("El registro ha sido actualizado exitosamente");
                    limpiar();
                    llenarGrid();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            else MessageBox.Show("Los campos no deben quedar vacios");
        }
    }
}
