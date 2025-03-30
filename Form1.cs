namespace Mensagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult OpcaoUsuario = new DialogResult();

            OpcaoUsuario = MessageBox.Show("Atenção! Por favor reveja as informações", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (OpcaoUsuario == DialogResult.Cancel)
            {
                MessageBox.Show("Não esqueça de rever.", "Lembrete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quer mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
