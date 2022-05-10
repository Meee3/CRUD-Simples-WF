using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAula33_PreProva.domain;

namespace WFAula33_PreProva.Telas
{
    public partial class AtualizarCadastro : Form
    {
        public AtualizarCadastro()
        {
            InitializeComponent();
        }

        private void AtualizarCadastro_Load(object sender, EventArgs e)
        {
            foreach(var item in Program.cadastrarPessoas)
            {
                ltbAtuais.Items.Add(item);
            }
            
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {

            #region Alterar Nome
            if (ltbAtuais.Items.Count == 0)
            {
                MessageBox.Show("Não é possível realizar este operação.");
            }
            else
            {

            
            string nome = txtNomeAlterar.Text;

            int selectedIndex = ltbAtuais.SelectedIndex;
            Program.cadastrarPessoas[selectedIndex].Nome = nome;
            MessageBox.Show("Alterado com Sucesso");
            ltbAtuais.Items.Clear();
            foreach (var item in Program.cadastrarPessoas)
            {
                ltbAtuais.Items.Add(item);
            }
            }
            #endregion

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Alterar_Click_1(object sender, EventArgs e)
        {
            #region Alterar Sobrenome
            if (ltbAtuais.Items.Count == 0  ) 
            {
                MessageBox.Show("Não é possível realizar este operação.");
            }
            else
            {


                string sobrenome = txtSobrenomeAlterar.Text;

                int selectedIndex = ltbAtuais.SelectedIndex;
                Program.cadastrarPessoas[selectedIndex].Sobrenome = sobrenome;
                MessageBox.Show("Alterado com Sucesso");
                ltbAtuais.Items.Clear();
                foreach (var item in Program.cadastrarPessoas)
                {
                    ltbAtuais.Items.Add(item);
                }
            }
            #endregion
        }

        private void btn_AlterarIdade_Click(object sender, EventArgs e)
        {
            #region Alterar Idade
            if (ltbAtuais.Items.Count == 0 )
            {
                MessageBox.Show("Não é possível realizar este operação.");
            }
            else
            {


                int idade = int.Parse(txtIdadeAlterar.Text);

                int selectedIndex = ltbAtuais.SelectedIndex;
                Program.cadastrarPessoas[selectedIndex].Idade = idade;
                MessageBox.Show("Alterado com Sucesso");
                ltbAtuais.Items.Clear();
                foreach (var item in Program.cadastrarPessoas)
                {
                    ltbAtuais.Items.Add(item);
                }
            }
            #endregion
        }
    }
}
