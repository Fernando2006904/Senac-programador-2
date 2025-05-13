using GestãoRH;
using MySql.Data.MySqlClient;
using System.Data;
using visualPI;


namespace GestaoRH
{
    public partial class Interface_Inicial : Form
    {
        public Interface_Inicial()
        {

            InitializeComponent();


        }

        private void Interface_Inicial_Load(object sender, EventArgs e)
        {
            Repositorio.CarregarFuncionario();
            AtualizarDataGrid();
        }


        public void CarregarFuncionario()
        {

            var repositorio = new Repositorio();
            var dados = Repositorio.CarregarFuncionario();

            dataGridView1.DataSource = dados;

        }

        public void AtualizarDataGrid()
        {
            string conexaoString = "server = localhost; user = root; password =; database = gestaorh; ";

            using (var conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();
                string query = "SELECT * FROM Funcionario";
                var comando = new MySqlCommand(query, conexao);
                var adaptador = new MySqlDataAdapter(comando);
                var tabela = new DataTable();
                adaptador.Fill(tabela);

                dataGridView1.DataSource = tabela;
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {


            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }



        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                var funcionarioId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;


                Form1 form1 = new Form1(funcionarioId);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarDataGrid();
        }

        private void buttonAtualizar_Click_1(object sender, EventArgs e)
        {


            if (dataGridView1.CurrentRow != null)
            {

                var funcionarioId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;


                Form1 form1 = new Form1(funcionarioId);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}