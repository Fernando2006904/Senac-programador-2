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

                double numero1 = Convert.ToDouble(TextBoxN�mero1.Text);
                double numero2 = Convert.ToDouble(TextBoxN�mero2.Text);



                double resultado = numero1 + numero2;


                lblresultado.Text = "Resultado: " + resultado.ToString();




            }
            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um n�mero v�lido.";

            }


            {








            }

            {



            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                double numero1 = Convert.ToDouble(TextBoxN�mero1.Text);
                double numero2 = Convert.ToDouble(TextBoxN�mero2.Text);


                double resultado = numero1 - numero2;
                lblresultado.Text = "Resultado: " + resultado.ToString();
            }



            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um n�mero v�lido.";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                double numero1 = Convert.ToDouble(TextBoxN�mero1.Text);
                double numero2 = Convert.ToDouble(TextBoxN�mero2.Text);


                double resultado = numero1 * numero2;
                lblresultado.Text = "Resultado: " + resultado.ToString();

            }

            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um n�mero v�lido.";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = Convert.ToDouble(TextBoxN�mero1.Text);
                double numero2 = Convert.ToDouble(TextBoxN�mero2.Text);

                double resultado = numero1 / numero2;
                lblresultado.Text = "Resultado: " + resultado.ToString();





            }
            catch (Exception)
            {

                lblresultado.Text = "Por favor, insira " +
                    "um n�mero v�lido.";

            }


        }


    }
}
