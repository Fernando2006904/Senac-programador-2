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
    public partial class FormQuadrado : Form
    {
        public FormQuadrado()
        {
            InitializeComponent();
        }

        private void BntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoquadrado = Convert.ToDouble(TxtLadoQuadrado.Text);
                double areaquadrado = ladoquadrado * ladoquadrado;

                double larguraretangulo = Convert.ToDouble(TxtLarguraRetangulo.Text);
                double alturaretangulo = Convert.ToDouble(TxtAlturaRetangulo.Text);
                double arearetangulo = larguraretangulo * alturaretangulo;

                lblResultado.Text = $"Área do quadrado: {areaquadrado} \nÁrea do retângulo: {arearetangulo}";

                double perimetroquadrado = 4 * ladoquadrado;
                LblResultadoPerímetro.Text = "Perímetro do quadrado: " + perimetroquadrado.ToString();

                double perimetroretangulo = 2 * larguraretangulo + 2 * alturaretangulo;
                LblResultadoPerímetro.Text += "\nPerímetro do retângulo: " + perimetroretangulo.ToString();

                double profunidaderetangulo = Convert.ToDouble(TxtVolume1.Text);
                double Volumepararalelepipedo = larguraretangulo * alturaretangulo * profunidaderetangulo;

                Resultado2.Text = "Volume do paralelepípedo: " + Volumepararalelepipedo.ToString();


            }
            catch (FormatException)

            {
                MessageBox.Show("Digite um número válido");
            }


        }

        private void lblLadoQuadrado_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LblResultadoPerímetro_Click(object sender, EventArgs e)
        {

        }
    }


}
