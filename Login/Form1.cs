namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {









        }

        private void label3_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textboxusuario.Text;
            string senha = textboxsenha.Text;


            if (usuario == null || usuario == "")
            {
                labelresultado.Text = "usuario eh obrigatorio!!!";
                labelresultado.ForeColor = Color.Red;
                

            }







           else if (usuario == "Fernando.Lima" && senha == "12345")
            {
                labelresultado.Text = "Autenticado com sucesso";
                labelresultado.ForeColor = Color.Green;
            }
            else
            {
                labelresultado.Text = "usuario ou senha incorretos...";
                labelresultado.ForeColor = Color.Red;
            }


            


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void labelsenha_Click(object sender, EventArgs e)
        {

        }
    }
}
