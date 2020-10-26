using System;
using System.Windows;

namespace CalculosMatematicos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int numero1 = (int.Parse(Operando1TextBox.Text));
                int numero2 = (int.Parse(Operando2TextBox.Text));
                int resultado;

                if (OperadorTextBox.Text == "+")
                {
                    resultado = numero1 + numero2;
                }
                else if (OperadorTextBox.Text == "-")
                {
                    resultado = numero1 - numero2;
                }
                else if (OperadorTextBox.Text == "*")
                {
                    resultado = numero1 * numero2;
                }
                else if (OperadorTextBox.Text == "/")
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    resultado = 0;
                    Console.WriteLine("Error 1234");
                }
                ResultadoTextBox.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los operadores");
            }

        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "";
            Operando2TextBox.Text = "";
            OperadorTextBox.Text = "";
            ResultadoTextBox.Text = "";
        }

        private void OperadorTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(Operando2TextBox.Text) && !String.IsNullOrEmpty(Operando1TextBox.Text) && !String.IsNullOrEmpty(OperadorTextBox.Text) && (OperadorTextBox.Text == "+"|| OperadorTextBox.Text=="-" || OperadorTextBox.Text == "*" || OperadorTextBox.Text == "/"))
            {
                CalcularButton.IsEnabled = true;
            }
            else
            {
                CalcularButton.IsEnabled = false;
            }
        }

    }
}
