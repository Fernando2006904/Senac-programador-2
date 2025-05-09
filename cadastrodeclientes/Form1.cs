using System.Text.RegularExpressions;

namespace cadastrodeclientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string email = textBox2.Text;
            string telefone = maskedTextBox1.Text;



            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("O campo email precisa de um @.","Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (!Regex.IsMatch(telefone, @"^\(?\d{2}\)?[\s-]?\d{4,5}-?\d{4}$"))
            {

                MessageBox.Show("Digite um telefone válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Focus();

            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }
    }
}
