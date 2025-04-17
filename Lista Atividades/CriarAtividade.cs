using Lista_Atividades.Domínio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Atividades
{
    public partial class CriarAtividade : Form
    {
        public CriarAtividade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CriarAtividade_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade()
            {
                Titulo = textBox1.Text,

            };
            if (!atividade.Criar())
            {
                labelErro.Text = "Não foi possível criar a atividade.";
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
