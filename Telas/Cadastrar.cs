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
using WFAula33_PreProva;

namespace WFAula33_PreProva.Telas
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }
        int contador = -1;

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            contador++;
            string nome, sobrenome;
            int idade;
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            idade = int.Parse(txtIdade.Text);
          

            Program.cadastrarPessoas.Add(new Pessoa(nome, sobrenome, idade));
            MessageBox.Show($"Cadastro Efetuado com Sucesso! ({(contador+1)})");
            //MessageBox.Show(Program.cadastrarPessoas[contador].ToString());

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
