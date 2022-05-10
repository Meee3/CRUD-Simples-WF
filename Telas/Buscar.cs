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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            var Pesquisar = txtBoxPesquisar.Text.ToUpper();
            var ResultadoPesquisado = "";
            if (Program.cadastrarPessoas.Count == 0)
            {
                lblResultado.Text = "Não Encontrado";

            }
            else
            {


                for (int i = 0; i < Program.cadastrarPessoas.Count(); i++)
                {
                    if (Program.cadastrarPessoas[i].Nome.ToUpper().Contains(Pesquisar))
                    {
                        lblResultado.Text = "Encontrado na lista dos Ativos";

                        ResultadoPesquisado += Program.cadastrarPessoas[i].ToString() + " Salário Fixo: " + Pessoa.salarioFixo + "\n\n";
                    }
                    else if (Program.listaRemovidos[i].Nome.Contains(Pesquisar))
                    {
                        ResultadoPesquisado = lblResultado.Text = "Encontrado na Lista dos Desativados!!!";
                    }
                    else
                    {
                        ResultadoPesquisado =  lblNome.Text = "Não Encontrado";
                    };

                    

                }
                lblNome.Text = ResultadoPesquisado;
            }
        }

    }
}
