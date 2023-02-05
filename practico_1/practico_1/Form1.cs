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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_button_Click(object sender, EventArgs e)
        {
            // variables

            decimal numero1 = 0;
            decimal numero2 = 0;

            numero1 = Convert.ToDecimal(Numero1_textBox.Text);
            numero2 = Convert.ToDecimal(Numero2_textBox.Text);

            decimal suma = numero1 + numero2;

           // MessageBox.Show("La suma es: " + suma);

           // MostrarMesaje();

            MessageBox.Show(Convert.ToString(Calcular(numero1, numero2)));
        }
       
        // procedimiento

        private void MostrarMesaje()
        {
            MessageBox.Show("HOLA USUARIO: " + "Bienvenidos");
           
        }

        // funcion
        private decimal Calcular(decimal n1, decimal n2)
        {

            return n1 + n2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }







}
