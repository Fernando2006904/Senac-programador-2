using Lista_Atividades.Domínio;

namespace Lista_Atividades
{
    public partial class Form1 : Form
    {
        private List<Atividade> atividadesPendentes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Atividade atividade = new();

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            textBox1AtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}"; 
            
            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadeEmAndamento;
            
        }
    }
}
