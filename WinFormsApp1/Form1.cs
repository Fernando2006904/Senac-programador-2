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
        List<string> listaSenhas = new List<string>() { "bruna, 12345, 777" };
        List<string> listasenhas = new List<string>() { "brun@123", "12345Abc!", "sete777sete" };

        List<char> alfabetominusculo = new List<char>() { 'a', 'b', 'c' };
        List<char> alfabetomaiusculo = new List<char>() { 'A', 'B', 'C' };
        List<char> numeros = new List<char>() { '1', '2', '3' };
        List<char> caracteresespeciais = new List<char>() { '@', '!', '#' };


















        private void label1_Click(object sender, EventArgs e)
        {





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string listaemails = textBox2.Text;
            string novoUsuario = textNovoUsuario.Text;
            string novaSenha = textBox2.Text;
            string labelNovoUsuario;
            bool usuarioEncontrado = false;
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (novoUsuario == listausuarios[i])
                {

                    usuarioEncontrado = true;
                }
            }
            if (!usuarioEncontrado)

            {
                listausuarios.Add(novoUsuario);

                labelNovoUsuario = "Usu�rio cadastrado com sucesso!!!";
            }




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

            string usuariobuscado = textNovoUsuario.Text;
            string senha = textBox2.Text;
            string novasenha = textBox5.Text;




            if (string.IsNullOrEmpty(novasenha))
            {








            }

























            {

            }


            string email = textNovoUsuario.Text;


            if (email == string.Empty)
            {
                label5.Text = "Email � obrigat�rio!!!";
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
                    label5.ForeColor = Color.Green;
                }
                else
                {
                    label5.Text = "usuario ou senha incorretas!!!";
                    label5.ForeColor = Color.Red;
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
                label7.Text = "Senha � obrigat�ria!!!";
                label7.ForeColor = Color.Red;

            }

            int pocisaosenhaencontrada = -1;
            for (int i = 0; i < listasenhas.Count; i++)
            {
                if (pocisaosenhaencontrada == -1)
                {
                    pocisaosenhaencontrada = i;
                }






                string nome = textBox3.Text;
                string cpf = textBox4.Text;

                if (nome == string.Empty)
                {
                    label8.Text = "Nome � obrigat�rio!!!";
                    label8.ForeColor = Color.Red;
                }

                if (cpf == string.Empty)
                {
                    label9.Text = "CPF � obrigat�rio!!!";
                    label9.ForeColor = Color.Red;
                }


                else if (email == "Fefe17@gmail" && senha == "Fefe18@!!")
                {











                    label7.Text = "Login efetuado com sucesso!!!";
                    label7.ForeColor = Color.Green;
                }




















                else
                {
                    label7.Text = "Email ou senha inv�lidos!!!";
                    label7.ForeColor = Color.Red;
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




            void label6_Click(object sender, EventArgs e)
            {

            }

            void label4_Click(object sender, EventArgs e)
            {




            }

            void button2_Click(object sender, EventArgs e)
            {




            }

            void label5_Click(object sender, EventArgs e)
            {

            }

            void label7_Click(object sender, EventArgs e)
            {

            }

            void textBox5_TextChanged(object sender, EventArgs e)
            {

            }

            void button2_Click_1(object sender, EventArgs e)
            {


                {


                    {




                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string novoUsuario = textNovoUsuario.Text;
            string novaSenha = textBox2.Text;
























            if (string.IsNullOrEmpty(novoUsuario))
            {




                labelnovousuario.Text = "Usu�rio � obrigat�rio!!!";

            }
            if (string.IsNullOrEmpty(novaSenha))
            {
                labelnovousuario.Text = "Senha � obrigat�ria!!!";
                labelresultado.Text = "Senha � obrigat�ria!!!";
                return;
            }

            bool usuarioEncontrado = false;
            for (int i = 0; i < listausuarios.Count; i++)
                if (novaSenha.Length < 8)
                {

                    if (novoUsuario == listausuarios[i])
                    {
                        usuarioEncontrado = true;
                    }

                    labelresultado.Text = "Senha deve ter no m�nimo 8 caracteres!!!";
                    return;


                }






            {




                {
                    if (!usuarioEncontrado)
                        if (!novaSenha.Any(char.IsUpper))
                        {
                            listausuarios.Add(novoUsuario);
                            listasenhas.Add(novaSenha);
                            labelnovousuario.Text = "Usu�rio cadastrado com sucesso!!!";
                            labelresultado.Text = "Senha deve ter no m�nimo 1 letra mai�scula!!!";
                            return;


                        }

                        else
                        if (!novaSenha.Any(char.IsLower))

                        {
                            labelresultado.Text = "Senha deve ter no m�nimo 1 letra min�scula!!!";
                            return;
                        }

                    if (!novaSenha.Any(char.IsDigit))
                    {
                        labelnovousuario.Text = "J� existe um �suario cadastrado!!!";
                        labelresultado.Text = "Senha deve ter no m�nimo 1 n�mero!!!";
                        return;
                    }

                    if (novaSenha.Any(char.IsPunctuation))
                    {
                        labelresultado.Text = "Senha deve ter no m�nimo 1 caractere especial!!!";
                        return;
                    }

                    if (novaSenha.Any(char.IsWhiteSpace))
                    {
                        labelresultado.Text = "Senha n�o pode ter espa�os em branco!!!";
                        return;
                    }

                    if (listausuarios.Contains(novoUsuario))
                    {
                        labelnovousuario.Text = "J� existe um usu�rio cadastrado!!!";
                        return;
                    }
                    else
                    {
                        listausuarios.Add(novoUsuario);
                        listasenhas.Add(novaSenha);
                        labelnovousuario.Text = "Usu�rio cadastrado com sucesso!!!";

                    }


                }


                {

                }

                {

                }


            }











        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {





        }

        private void labelnovousuario_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {





        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string novoUsuario = textNovoUsuario.Text;
            string novaSenha = textBox2.Text;


            if (string.IsNullOrEmpty(novoUsuario))
            {




                labelnovousuario.Text = "Usu�rio � obrigat�rio!!!";

            }


            if (string.IsNullOrEmpty(novaSenha))
            {
                labelnovousuario.Text = "Senha � obrigat�ria!!!";
                labelresultado.Text = "Senha � obrigat�ria!!!";
                
            }

            bool usuarioEncontrado = false;
            for (int i = 0; i < listausuarios.Count; i++)
                if (novaSenha.Length < 8)
                {

                    if (novoUsuario == listausuarios[i])
                    {
                        usuarioEncontrado = true;
                    }

                    labelresultado.Text = "Senha deve ter no m�nimo 8 caracteres!!!";
                    return;


                }


            {
                if (!usuarioEncontrado)
                    if (!novaSenha.Any(char.IsUpper))
                    {
                        listausuarios.Add(novoUsuario);
                        listasenhas.Add(novaSenha);
                        labelnovousuario.Text = "Usu�rio cadastrado com sucesso!!!";
                        labelresultado.Text = "Senha deve ter no m�nimo 1 letra mai�scula!!!";
                        return;


                    }

                    else
                    if (!novaSenha.Any(char.IsLower))

                    {
                        labelresultado.Text = "Senha deve ter no m�nimo 1 letra min�scula!!!";
                        return;
                    }

                if (!novaSenha.Any(char.IsDigit))
                {
                    labelnovousuario.Text = "J� existe um �suario cadastrado!!!";
                    labelresultado.Text = "Senha deve ter no m�nimo 1 n�mero!!!";
                    return;
                }



                if (novaSenha.Any(char.IsPunctuation))
                {
                    labelresultado.Text = "Senha deve ter no m�nimo 1 caractere especial!!!";
                    return;
                }

                if (novaSenha.Any(char.IsWhiteSpace))
                {
                    labelresultado.Text = "Senha n�o pode ter espa�os em branco!!!";
                    return;
                }

                if (listausuarios.Contains(novoUsuario))
                {
                    labelnovousuario.Text = "J� existe um usu�rio cadastrado!!!";
                    return;
                }
                else
                {
                    listausuarios.Add(novoUsuario);
                    listasenhas.Add(novaSenha);
                    labelnovousuario.Text = "Usu�rio cadastrado com sucesso!!!";

























                }
            }

        }
    }
}
    

