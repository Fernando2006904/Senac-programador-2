using System.Linq.Expressions;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        private double resultado = 0;
        private string operacao = "";
        private bool digitandoNumero = false;

       


        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Soma");
            comboBox1.Items.Add("Subtração");
            comboBox1.Items.Add("Multiplicação");
            comboBox1.Items.Add("Divisão");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                double numero1 = Convert.ToDouble(TextBoxNúmero1.Text);
                double numero2 = Convert.ToDouble(TextBoxNúmero2.Text);



                double resultado = 0;




                lblresultado.Text = "Resultado: " + resultado.ToString();




            }
            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um número válido.";

            }


















        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                double numero1 = Convert.ToDouble(TextBoxNúmero1.Text);
                double numero2 = Convert.ToDouble(TextBoxNúmero2.Text);


                double resultado = numero1 - numero2;
                lblresultado.Text = "Resultado: " + resultado.ToString();
            }



            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um número válido.";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                double numero1 = Convert.ToDouble(TextBoxNúmero1.Text);
                double numero2 = Convert.ToDouble(TextBoxNúmero2.Text);


                double resultado = numero1 * numero2;
                lblresultado.Text = "Resultado: " + resultado.ToString();

            }

            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um número válido.";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = Convert.ToDouble(TextBoxNúmero1.Text);
                double numero2 = Convert.ToDouble(TextBoxNúmero2.Text);

                double resultado = numero1 / numero2;
                lblresultado.Text = "Resultado: " + resultado.ToString();





            }
            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um número válido.";

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = Convert.ToDouble(TextBoxNúmero1.Text);
                double numero2 = Convert.ToDouble(TextBoxNúmero2.Text);
                string operação = comboBox1.SelectedItem.ToString();
                double resultado = 0;

                switch (operação)
                {
                    case "Soma":
                        resultado = numero1 + numero2;
                        break;
                    case "Subtração":
                        resultado = numero1 - numero2;
                        break;
                    case "Multiplicação":
                        resultado = numero1 * numero2;
                        break;
                    case "Divisão":
                        resultado = numero1 / numero2;
                        break;
                    default:
                        break;
                }
                lblresultado.Text = "Resultado: " + resultado.ToString();

            }
            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um número válido.";

            }


















































        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            NovoForm novoForm = new NovoForm();
            novoForm.ShowDialog();

            this.Hide();
        }
    }
}

