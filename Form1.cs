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
using WFAula33_PreProva.Telas;

namespace WFAula33_PreProva
{
    public partial class Form1 : Form
    {
        private object lbRemover;

        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cadastrar cadastrar = new Telas.Cadastrar();
            cadastrar.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarCadastrados buscarCadastrados = new BuscarCadastrados();
            buscarCadastrados.Show();

            //RelatorioCadastro relatorioCadastro = new RelatorioCadastro();
            //relatorioCadastro.Show();
        }


        private void cadastrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoverCadastro removerCadastro = new RemoverCadastro();
            removerCadastro.ShowDialog();
            //listaRemover.Items.

            //foreach(string item in Program.cadastrarPessoas)
            //{
            //    RemoverCadastro.lbRemover.Items.Add(item);
            //}
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarCadastro atualizarCadastro = new AtualizarCadastro();
            atualizarCadastro.ShowDialog();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Show();
        }
    }
}
