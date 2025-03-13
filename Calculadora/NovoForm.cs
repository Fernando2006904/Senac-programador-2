using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class NovoForm : Form
    {
        public NovoForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double Basetriangulo = Convert.ToDouble(txtbase.Text);
                double AlturaTriangulo = Convert.ToDouble(txtaltura.Text);
                double lado1 = Convert.ToDouble(Lado1.Text);
                double lado2 = Convert.ToDouble(Lado2.Text);
                double lado3 = Convert.ToDouble(Lado3.Text);



                double area = (Basetriangulo * AlturaTriangulo) / 2;
                double perimetro = lado1 + lado2 + lado3;   

                LabelResultarea.Text = $"Área: {area} unidades quadradas";
                LabelResultPerímeter.Text = $"Perímetro: {perimetro} unidades";


            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            {
                
            }

        }
    }
}
