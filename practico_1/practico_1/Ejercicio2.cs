using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico_1
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_button_Click(object sender, EventArgs e)
        {
            if (Numero1_textBox.Text == "")
            {

                errorProvider1.SetError(Numero1_textBox, "Ingrese un valor");
                return;
            }
            errorProvider1.Clear();
            if (Numero2_textBox.Text == "")
            {
                errorProvider1.SetError(Numero2_textBox, "Ingrese un valor");
                return;
            }
            errorProvider1.Clear();

            decimal num1 = Convert.ToDecimal(Numero1_textBox.Text);
            decimal num2 = Convert.ToDecimal(Numero2_textBox.Text);
            Resultado_label.Text = Calcular(num1, num2).ToString();
        }
        private decimal Calcular(decimal n1, decimal n2)
        {
            string operacion = Operaciones_comboBox.Text;


            decimal resultado = 0;

            if (operacion == "Suma")
                resultado = n1 + n2;
            else if (operacion == "Resta")
                resultado = n1 - n2;
            else if (operacion == "Multiplicacion")
                resultado = n1 * n2;
            else if (operacion == "Division")
                resultado = n1 / n2;

            return resultado;

        }



    }

}

