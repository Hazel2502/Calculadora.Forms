using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Forms
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, este el mi primer formulario");
        }

        private void comboOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            String itemSelected = comboOperaciones.Text;
            switch (itemSelected)
            {
                case "Suma":
                    double num1 = double.Parse(txtNum1.Text);
                    double num2 = double.Parse(txtNum2.Text);
                    var Suma = num1 + num2;
                    MessageBox.Show(Suma.ToString());
                    break;
                case "Resta":
                    double Num1 = double.Parse(txtNum1.Text);
                    double Num2 = double.Parse(txtNum2.Text);
                    var Resta = Num1 - Num2;
                    MessageBox.Show(Resta.ToString());
                    break;
                case "Multiplicacion":
                    double NUM1 = Convert.ToDouble(txtNum1.Text);
                    double NUM2 = Convert.ToDouble(txtNum2.Text);
                    double Multiplicacion = NUM1 * NUM2;
                    MessageBox.Show(Multiplicacion.ToString());
                    break;

                case "División":
                    double NUm1 = Convert.ToDouble(txtNum1.Text);
                    double NUm2 = Convert.ToDouble(txtNum2.Text);
                    double División = NUm1 / NUm2;
                    MessageBox.Show(División.ToString());


            }
            MessageBox.Show(itemSelected);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string itemSelected = comboOperaciones.Text;
            MessageBox.Show(itemSelected);
        }
    }
}
