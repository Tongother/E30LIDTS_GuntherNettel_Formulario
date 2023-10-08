using System.Text;
using System.Text.RegularExpressions;

namespace Formulario_validacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbNombre.TextChanged += ValidarNombre;
            tbApellido.TextChanged += ValidarApellidos;
            tbEdad.TextChanged += ValidarEdad;
            tbEstatura.TextChanged += ValidarEstatura;
            tbTelefono.TextChanged += ValidarTelefono;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;

            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
        }

        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido (solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un apellido válido (solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            input = input.Replace(" ", "").Replace("-", "");
            if(input.Length > 10)
            {
                if (!EsEnteroValidoDe10Digitos(input))
                {
                    MessageBox.Show("Por favor, ingrese un téfono valido de 10 digitos válido (solo números)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }else if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor, ingrese un téfono valido de 10 digitos válido (solo números)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una estatura válida (solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una edad válida (solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado);
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$"); //Solo letras y espacios
        }
    }
}