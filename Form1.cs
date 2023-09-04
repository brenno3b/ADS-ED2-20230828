using ADS_ED2_20230828.Controller;
using ADS_ED2_20230828.Models;

namespace ADS_ED2_20230828
{
    public partial class Form1 : Form
    {
        ContatosController contatosController = new ContatosController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] options = new string[] { "Móvel", "Residencial", "Comercial" };

            tipoDropDown.Items.AddRange(options);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email = emailTxtBox.Text;
            String nome = nomeTxtBox.Text;
            int dia = int.Parse(diaTxtBox.Text);
            int mes = int.Parse(mesTxtBox.Text);
            int ano = int.Parse(anoTxtBox.Text);

            ContatoModel newContact = new(email, nome, new DataModel(dia, mes, ano), new List<TelefoneModel>());

            contatosController.Adicionar(newContact);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String email = emailTxtBox.Text;

            ContatoModel foundContact = contatosController.Pesquisar(new ContatoModel(email));

            String nome = nomeTxtBox.Text;
            int dia = int.Parse(diaTxtBox.Text);
            int mes = int.Parse(mesTxtBox.Text);
            int ano = int.Parse(anoTxtBox.Text);

            ContatoModel editedContact = new(email, nome, new DataModel(dia, mes, ano), foundContact.Telefones);

            contatosController.Alterar(editedContact);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contatoDGV.Rows.Clear();

            String email = emailTxtBox.Text;

            ContatoModel foundContact = contatosController.Pesquisar(new ContatoModel(email));

            contatoDGV.Rows.Add(
                foundContact.Email,
                    foundContact.Nome,
                    foundContact.Data.ToString(),
                    foundContact.GetIdade(),
                    foundContact.GetTelefonePrincipal()
                );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            contatoDGV.Rows.Clear();

            foreach (ContatoModel contact in contatosController.Agenda)
            {
                contatoDGV.Rows.Add(
                    contact.Email,
                    contact.Nome,
                    contact.Data.ToString(),
                    contact.GetIdade(),
                    contact.GetTelefonePrincipal()
                    );
            }
        }

        private void contatoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String email = emailTxtBox.Text;

            ContatoModel foundContact = contatosController.Pesquisar(new ContatoModel(email));

            contatosController.Remover(foundContact);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String tipo = tipoDropDown.Text;
            String numero = numeroTxtBox.Text;
            bool principal = principalCB.Checked;

            String email = emailTxtBox.Text;

            ContatoModel foundContact = contatosController.Pesquisar(new ContatoModel(email));

            foundContact.AdicionarTelefone(new TelefoneModel(tipo, numero, principal));

            foreach (TelefoneModel telefone in foundContact.Telefones)
            {
                telefoneDGV.Rows.Add(
                    telefone.Tipo,
                    telefone.Numero,
                    telefone.Principal
                    );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}