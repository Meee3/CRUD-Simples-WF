using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAula33_PreProva.Telas
{
    public partial class BuscarCadastrados : Form
    {
        public BuscarCadastrados()
        {
            InitializeComponent();
        }

        private void BuscarCadastrados_Load(object sender, EventArgs e)
        {
            foreach(var a in Program.cadastrarPessoas)
            {
                ltbFuncionarioRelatorio.Items.Add(a);
            }

            lbResultadoTotal.Text = Program.cadastrarPessoas.Count+"";
            double salarioTotal = Program.cadastrarPessoas.Count * domain.Pessoa.salarioFixo;
            //lblResultadoSalarios.Text = Program.cadastrarPessoas.Count * domain.Pessoa.salarioFixo.ToString("F2");
            lblResultadoSalarios.Text = "R$: " + salarioTotal.ToString();
            double comissao = salarioTotal * 0.3;
            lblComissaoCadastrados.Text = "R$: " + (salarioTotal * 0.3).ToString("F2");

            lblResultadoTotal.Text = "R$: " + (salarioTotal + comissao).ToString("F2");
        }

        private void lblResultadoSalarios_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
