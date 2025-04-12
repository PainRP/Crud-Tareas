using Form1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Form1
{
    public partial class Form1 : Form
    {
        Crud miCrud = new Crud();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola te saludo desde el formulario");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string resultado = miCrud.Mostrarinformacion(textBoxCarnet.Text);
            string[] datos = resultado.Split(',');

            textBoxEstudiante.Text = datos[0].Trim(); // nombre
            textBoxSeccion.Text = datos[1].Trim();    // seccion
            textBoxEmail.Text = datos[2].Trim();      // email


        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxEstudiante.Text;
            string carnet = textBoxCarnet.Text;
            string email = textBoxEmail.Text;
            string seccion = comboBoxSeccion.Text;
            string respuesta = miCrud.AgregarAlumno(carnet, nombre, email, seccion);
            MessageBox.Show(respuesta);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            string nombre = textBoxEstudiante.Text;
            string seccion = comboBoxSeccion.Text;
            string email = textBoxEmail.Text;
            string respuesta = miCrud.ActualizarAlumno(carnet, nombre, seccion, email);
            MessageBox.Show(respuesta);
        }
        private void Form1_Load(object sender, EventArgs e){}

        private void buttonTareas_Click(object sender, EventArgs e)
        {
            Form2 FormTareas = new Form2();
            FormTareas.Show();
            this.Hide();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string resultado = miCrud.EliminarInformacion(textBoxCarnet.Text);
            MessageBox.Show(resultado);
        }
    }
}
