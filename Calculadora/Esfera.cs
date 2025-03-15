using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Esfera : Form
    {
        public Esfera()
        {
            InitializeComponent();
        }

        private double CalcularCircunferência_Click(double raio)
        {
            return 2 * Math.PI * raio;
        }

        private double CalculoVolume_Click(double raio)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

        }

        private void BntCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double raio = Convert.ToDouble(textBox1.Text);


                double circunferência = CalcularCircunferência_Click(raio);
                double volume = CalculoVolume_Click(raio);

                CalcularCircunferência.Text = $"Circunferência: {circunferência:F2} unidades";
                CalculoVolume.Text = $"Volume: {volume:F2} unidades cúbicas";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double volume = CalculoVolume_Click(Convert.ToDouble(textBox1.Text));
            double circunferência = CalcularCircunferência_Click(Convert.ToDouble(textBox1.Text));
        }
    }
}

