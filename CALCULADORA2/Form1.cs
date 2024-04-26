using System;
using System.Windows.Forms;
using CALCULADORA2.Clases;

namespace CALCULADORA2
{
    public partial class CALCULADORA2 : Form
    {
        double primero;
        double segundo;
        string operador;
        ClsOperaciones operaciones = new ClsOperaciones();

        public CALCULADORA2()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tbxScreen.Text += btn.Text;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operador = btn.Text;
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = operaciones.Sumar(primero, segundo);
                    break;
                case "-":
                    resultado = operaciones.Restar(primero, segundo);
                    break;
                case "*":
                    resultado = operaciones.Multiplicar(primero, segundo);
                    break;
                case "/":
                    if (segundo != 0)
                    {
                        resultado = operaciones.Dividir(primero, segundo);
                    }
                    else
                    {
                        MessageBox.Show("Error: División por cero");
                    }
                    break;
            }

            tbxScreen.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length > 0)
            {
                tbxScreen.Text = tbxScreen.Text.Remove(tbxScreen.Text.Length - 1, 1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}