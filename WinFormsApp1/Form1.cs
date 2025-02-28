using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listausuarios = new List<string>() { "neymar.jr, pablo.vitar, sukuna silva" };
        List<string> listaemails = new List<string>() { "bruna, 12345, 777" };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuariobuscado;

            
                
            
            
            {
                
            }


            string email = textBox1.Text;
            string senha = textBox2.Text;

            if (email == string.Empty)
            {
                label5.Text = "Email é obrigatório!!!";
                label5.ForeColor = Color.Red;
                
            }
            int pocisaousuarioencontrado = -1;
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (pocisaousuarioencontrado == -1)
                {
                    pocisaousuarioencontrado = i;
                }




                if (pocisaousuarioencontrado != -1)
                {
                    label5.Text = "Autenticado com sucesso!!!";
                    label5.ForeColor = Color.Red;
                }
                else
                {
                    label5.Text = "usuario ou senha incorretas!!!";
                    label5.ForeColor = Color.Green;
                }


                {
                    
                    {
                        
                    }
                }
                {
                    
                    
                }
            }








            if (senha == string.Empty)
            {
                label7.Text = "Senha é obrigatória!!!";
                label7.ForeColor = Color.Red;
                
            }
            string nome = textBox3.Text;
            string cpf = textBox4.Text;

            if (nome == string.Empty)
            {
                label8.Text = "Nome é obrigatório!!!";
                label8.ForeColor = Color.Red;
            }

            if (cpf == string.Empty)
            {
                label9.Text = "CPF é obrigatório!!!";
                label9.ForeColor = Color.Red;
            }


            else if (email == "Fefe17@gmail" && senha == "Fefe18")
            {
                label7.Text = "Login efetuado com sucesso!!!";
                label7.ForeColor = Color.Green;
            }
            else
            {
                label7.Text = "Email ou senha inválidos!!!";
                label7.ForeColor = Color.Green;
            }




            {

            }

            

            {

            }



            {



            }

            {















            }

        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

