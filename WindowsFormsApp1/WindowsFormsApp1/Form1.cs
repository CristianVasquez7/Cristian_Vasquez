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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar?",
                             "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta == DialogResult.Yes)
            {
                origen.CommandText = "Delete From Cliente Where Id_cliente = " + dataGridView1 + "; ";
                origen.Connection = Coneccion;
                Coneccion.Open();
                origen.ExecuteNonQuery();
                Coneccion.Close();
                MessageBox.Show("Cliente Eliminado Exitosamente");
                limpiar();
                llenarGrid();
            }
            else if (respuesta == DialogResult.No) llenarGrid();

        }
    }
    }
}
