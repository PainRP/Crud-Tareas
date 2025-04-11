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
    public partial class Form2 : Form
    {
        Crud miCrud = new Crud();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonEstudiante_Click(object sender, EventArgs e)
        {
            Form1 FormEstudiante = new Form1();
            FormEstudiante.Show();
            this.Hide();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = miCrud.MostrarinformacionTarea(textBoxCarnet.Text);

            //string resultado = miCrud.MostrarinformacionTarea(textBoxCarnet.Text);
            //string[] datos = resultado.Split(',');
            //textBoxNombre.Text = datos[0].Trim(); // nombre
            //textBoxID.Text = datos[1].Trim();    // ID
            //textBoxNota1.Text = datos[2].Trim();    // nota1
            //textBoxNota2.Text = datos[3].Trim();    // nota2
            //textBoxNota3.Text = datos[4].Trim();    // nota3
            //textBoxNota4.Text = datos[5].Trim();    // nota4

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            string nota1 = textBoxNota1.Text;
            string nota2 = textBoxNota2.Text;
            string nota3 = textBoxNota3.Text;
            string nota4 = textBoxNota4.Text;
    
            string resultado = miCrud.AgregarTarea(carnet, nota1, nota2, nota3, nota4);

            MessageBox.Show(resultado);

            dataGridView1.DataSource = miCrud.MostrarinformacionTarea(carnet);
        }
    }
}
