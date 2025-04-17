using Lista_Atividades.Domínio;

namespace Lista_Atividades
{
    public partial class Form1 : Form
    {
        private Atividade? atividadeEmAndamento;
        private List<Atividade> atividadesPendentes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Atividade atividade = new();

            labelErro.Text = string.Empty;

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.Id > 0)
            {
                textBox1AtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            }


            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadeEmAndamento;
            CarregarListadeAtividade();
            CarregarAtividadeEmAndamento();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento == null)
            {
                labelErro.Text = "Nenhuma atividade em andamento.";
                return;
            }
            if (!atividadeEmAndamento.Atualizarsituacao())
            {
                labelErro.Text = "Erro ao atualizar a situação da atividade.";
                return;
            }

            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();



            labelErro.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione uma atividade.";
                return;
            }
            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];
            Atividade atividade = new()
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value,




            };
            if (!atividade.Atualizarsituacao())
            {
                labelErro.Text = "Não foi possível atualizar a atividade.";
            }
            labelErro.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = new CriarAtividade().ShowDialog();
            if (resultado == DialogResult.OK)
            {
                labelErro.Text = "Criação da atividade não foi concluida.";
            }
            labelErro.Text = "Atividade criada com sucesso.";
            CarregarListadeAtividade();

        }

        private void CarregarListadeAtividade()
        {
            Atividade atividade = new();
            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesPendentes;
        }

        private void CarregarAtividadeEmAndamento()
        {

            Atividade atividade = new();
            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.Id > 0)
            {
                textBox1AtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            }

        }

        private void textBox1AtividadeEmAndamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

