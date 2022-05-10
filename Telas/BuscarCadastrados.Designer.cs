namespace WFAula33_PreProva.Telas
{
    partial class BuscarCadastrados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ltbFuncionarioRelatorio = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCadastrados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbResultadoTotal = new System.Windows.Forms.Label();
            this.lblResultadoSalarios = new System.Windows.Forms.Label();
            this.lblComissaoCadastrados = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório Cadastrados";
            // 
            // ltbFuncionarioRelatorio
            // 
            this.ltbFuncionarioRelatorio.FormattingEnabled = true;
            this.ltbFuncionarioRelatorio.Location = new System.Drawing.Point(12, 112);
            this.ltbFuncionarioRelatorio.Name = "ltbFuncionarioRelatorio";
            this.ltbFuncionarioRelatorio.Size = new System.Drawing.Size(145, 225);
            this.ltbFuncionarioRelatorio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista Cadastrados";
            // 
            // lblTotalCadastrados
            // 
            this.lblTotalCadastrados.AutoSize = true;
            this.lblTotalCadastrados.Location = new System.Drawing.Point(219, 112);
            this.lblTotalCadastrados.Name = "lblTotalCadastrados";
            this.lblTotalCadastrados.Size = new System.Drawing.Size(99, 13);
            this.lblTotalCadastrados.TabIndex = 3;
            this.lblTotalCadastrados.Text = "Total Cadastrados: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Custos com Salários: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comissões: ";
            // 
            // lbResultadoTotal
            // 
            this.lbResultadoTotal.AutoSize = true;
            this.lbResultadoTotal.Location = new System.Drawing.Point(365, 112);
            this.lbResultadoTotal.Name = "lbResultadoTotal";
            this.lbResultadoTotal.Size = new System.Drawing.Size(55, 13);
            this.lbResultadoTotal.TabIndex = 4;
            this.lbResultadoTotal.Text = "Resultado";
            // 
            // lblResultadoSalarios
            // 
            this.lblResultadoSalarios.AutoSize = true;
            this.lblResultadoSalarios.Location = new System.Drawing.Point(365, 135);
            this.lblResultadoSalarios.Name = "lblResultadoSalarios";
            this.lblResultadoSalarios.Size = new System.Drawing.Size(90, 13);
            this.lblResultadoSalarios.TabIndex = 4;
            this.lblResultadoSalarios.Text = "Resultado Salario";
            this.lblResultadoSalarios.Click += new System.EventHandler(this.lblResultadoSalarios_Click);
            // 
            // lblComissaoCadastrados
            // 
            this.lblComissaoCadastrados.AutoSize = true;
            this.lblComissaoCadastrados.Location = new System.Drawing.Point(365, 159);
            this.lblComissaoCadastrados.Name = "lblComissaoCadastrados";
            this.lblComissaoCadastrados.Size = new System.Drawing.Size(103, 13);
            this.lblComissaoCadastrados.TabIndex = 4;
            this.lblComissaoCadastrados.Text = "Resultado Comissão";
            this.lblComissaoCadastrados.Click += new System.EventHandler(this.lblResultadoSalarios_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(11, 346);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 5;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(219, 184);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.AutoSize = true;
            this.lblResultadoTotal.Location = new System.Drawing.Point(365, 184);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(82, 13);
            this.lblResultadoTotal.TabIndex = 7;
            this.lblResultadoTotal.Text = "Resultado Total";
            // 
            // BuscarCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 375);
            this.Controls.Add(this.lblResultadoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.lblComissaoCadastrados);
            this.Controls.Add(this.lblResultadoSalarios);
            this.Controls.Add(this.lbResultadoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalCadastrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltbFuncionarioRelatorio);
            this.Controls.Add(this.label1);
            this.Name = "BuscarCadastrados";
            this.Text = "BuscarCadastrados";
            this.Load += new System.EventHandler(this.BuscarCadastrados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltbFuncionarioRelatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCadastrados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbResultadoTotal;
        private System.Windows.Forms.Label lblResultadoSalarios;
        private System.Windows.Forms.Label lblComissaoCadastrados;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblResultadoTotal;
    }
}