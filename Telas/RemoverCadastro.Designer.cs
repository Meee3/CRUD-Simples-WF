namespace WFAula33_PreProva.Telas
{
    partial class RemoverCadastro
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.brnDesfazer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbRemovido = new System.Windows.Forms.ListBox();
            this.listBox1Remover = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNomeAtualizar = new System.Windows.Forms.TextBox();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Cadastrados";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(200, 100);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // brnDesfazer
            // 
            this.brnDesfazer.Location = new System.Drawing.Point(200, 160);
            this.brnDesfazer.Name = "brnDesfazer";
            this.brnDesfazer.Size = new System.Drawing.Size(75, 23);
            this.brnDesfazer.TabIndex = 2;
            this.brnDesfazer.Text = "Desfazer";
            this.brnDesfazer.UseVisualStyleBackColor = true;
            this.brnDesfazer.Click += new System.EventHandler(this.brnDesfazer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista Removidos";
            // 
            // ltbRemovido
            // 
            this.ltbRemovido.FormattingEnabled = true;
            this.ltbRemovido.Location = new System.Drawing.Point(311, 100);
            this.ltbRemovido.Name = "ltbRemovido";
            this.ltbRemovido.Size = new System.Drawing.Size(177, 147);
            this.ltbRemovido.TabIndex = 4;
            // 
            // listBox1Remover
            // 
            this.listBox1Remover.FormattingEnabled = true;
            this.listBox1Remover.Location = new System.Drawing.Point(12, 100);
            this.listBox1Remover.Name = "listBox1Remover";
            this.listBox1Remover.Size = new System.Drawing.Size(177, 316);
            this.listBox1Remover.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            this.label3.Visible = false;
            // 
            // txtBoxNomeAtualizar
            // 
            this.txtBoxNomeAtualizar.Location = new System.Drawing.Point(311, 363);
            this.txtBoxNomeAtualizar.Name = "txtBoxNomeAtualizar";
            this.txtBoxNomeAtualizar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomeAtualizar.TabIndex = 6;
            this.txtBoxNomeAtualizar.Visible = false;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(432, 363);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 7;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Visible = false;
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(311, 275);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(40, 13);
            this.Buscar.TabIndex = 8;
            this.Buscar.Text = "Buscar";
            this.Buscar.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(432, 302);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Visible = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(12, 468);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // RemoverCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 503);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxNomeAtualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1Remover);
            this.Controls.Add(this.ltbRemovido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brnDesfazer);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label1);
            this.Name = "RemoverCadastro";
            this.Text = "RemoverCadastro";
            this.Load += new System.EventHandler(this.RemoverCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button brnDesfazer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbRemovido;
        public  System.Windows.Forms.ListBox lbRemover;
        public System.Windows.Forms.ListBox listBox1Remover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNomeAtualizar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_voltar;
    }
}