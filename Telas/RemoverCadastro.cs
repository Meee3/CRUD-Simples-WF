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
    public partial class RemoverCadastro : Form
    {
        public RemoverCadastro()
        {
            InitializeComponent();
        }

        private void lbRemover_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RemoverCadastro_Load(object sender, EventArgs e)
        {

            foreach (object item in Program.cadastrarPessoas)
            {
                listBox1Remover.Items.Add(item);

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox1Remover.Items.Count == 0)
            {
                MessageBox.Show("Não é possível realizar esta operação!");
            }
            else
            {
                int tamanhoDaLista = (listBox1Remover.SelectedIndex);
                //int tamanhoDaLista = (lbRemover.SelectedIndex);
                // MessageBox.Show(tamanhoDaLista + "");

                Program.listaRemovidos.Add((Program.cadastrarPessoas[tamanhoDaLista]));

                ltbRemovido.Items.Add(Program.cadastrarPessoas[tamanhoDaLista]);
                Program.cadastrarPessoas.RemoveAt(tamanhoDaLista);
                listBox1Remover.Items.RemoveAt(tamanhoDaLista);
                // listBox1Remover.ClearSelected();
                //listBox1Remover.Items.RemoveAt(tamanhoDaLista);
            }
        }

        private void brnDesfazer_Click(object sender, EventArgs e)
        {
            if (listBox1Remover.Items.Count == 0 && ltbRemovido.Items.Count == 0)
            {

            }
            else
            {
                if(ltbRemovido.Items.Count == 0)
                {

                }
                else
                {

                

                MessageBox.Show("Desfeito");

                int posicaoItemRemovido = ltbRemovido.SelectedIndex;
                //MessageBox.Show(posicaoItemRemovido+"");
                listBox1Remover.Items.Add(Program.listaRemovidos[posicaoItemRemovido]);
                //Program.cadastrarPessoas.Add();
                //A Fazer a parte DESFEITO
                //Program.cadastrarPessoas.Add(new Pessoa(ltbRemovido.Items.Nome,
                //    Program.cadastrarPessoas[posicaoItemRemovido].Sobrenome,
                //    Program.cadastrarPessoas[posicaoItemRemovido].Idade));

                ltbRemovido.Items.RemoveAt(posicaoItemRemovido);

                    // DialogResult dialogResult = MessageBox.Show(Program.cadastrarPessoas.Count.ToString());
                    //DialogResult dialogResult1 = MessageBox.Show(listBox1Remover.Items.Count.ToString());
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
