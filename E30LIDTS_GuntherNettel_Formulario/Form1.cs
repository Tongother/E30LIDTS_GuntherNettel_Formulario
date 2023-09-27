using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E30LIDTS_GuntherNettel_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = tbNombre.Text, apellidos = tbApellidos.Text, edad = tbEdad.Text, estatura = tbEstatura.Text, telefono = tbTelefono.Text;

            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTeléfono: {telefono}\r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}";
            string rutaArchivo = "C:\\Users\\nette\\OneDrive\\Documentos\\Archivos txt\\Datos.txt";

            bool archivoExiste = File.Exists(rutaArchivo);

            using(StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine(datos);
                }

                MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}
