
namespace ProvaPOO
{
    partial class frmHipermercado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHipermercado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBoxCaixa = new System.Windows.Forms.GroupBox();
            this.cbxPagamento = new System.Windows.Forms.ComboBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.chkQuilo = new System.Windows.Forms.CheckBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.groupBoxRemover = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cbxRemover = new System.Windows.Forms.ComboBox();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.txtNotinha = new System.Windows.Forms.TextBox();
            this.lblNotinha = new System.Windows.Forms.Label();
            this.btnVerificarLucro = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCaixa.SuspendLayout();
            this.groupBoxRemover.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(12, 176);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";
            // 
            // groupBoxCaixa
            // 
            this.groupBoxCaixa.Controls.Add(this.cbxPagamento);
            this.groupBoxCaixa.Controls.Add(this.lblPagamento);
            this.groupBoxCaixa.Controls.Add(this.btnPagamento);
            this.groupBoxCaixa.Controls.Add(this.btnFinalizar);
            this.groupBoxCaixa.Controls.Add(this.btnAdicionar);
            this.groupBoxCaixa.Controls.Add(this.chkQuilo);
            this.groupBoxCaixa.Controls.Add(this.txtPeso);
            this.groupBoxCaixa.Controls.Add(this.lblPeso);
            this.groupBoxCaixa.Controls.Add(this.txtQuantidade);
            this.groupBoxCaixa.Controls.Add(this.lblQuantidade);
            this.groupBoxCaixa.Controls.Add(this.txtPreco);
            this.groupBoxCaixa.Controls.Add(this.lblPreco);
            this.groupBoxCaixa.Controls.Add(this.txtProduto);
            this.groupBoxCaixa.Controls.Add(this.lblProduto);
            this.groupBoxCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCaixa.Location = new System.Drawing.Point(13, 208);
            this.groupBoxCaixa.Name = "groupBoxCaixa";
            this.groupBoxCaixa.Size = new System.Drawing.Size(315, 241);
            this.groupBoxCaixa.TabIndex = 3;
            this.groupBoxCaixa.TabStop = false;
            this.groupBoxCaixa.Text = "  Caixa  ";
            // 
            // cbxPagamento
            // 
            this.cbxPagamento.FormattingEnabled = true;
            this.cbxPagamento.Items.AddRange(new object[] {
            "Cartão",
            "Dinheiro"});
            this.cbxPagamento.Location = new System.Drawing.Point(19, 198);
            this.cbxPagamento.Name = "cbxPagamento";
            this.cbxPagamento.Size = new System.Drawing.Size(131, 25);
            this.cbxPagamento.TabIndex = 13;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPagamento.Location = new System.Drawing.Point(47, 178);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(74, 17);
            this.lblPagamento.TabIndex = 12;
            this.lblPagamento.Text = "Pagamento";
            // 
            // btnPagamento
            // 
            this.btnPagamento.Enabled = false;
            this.btnPagamento.Location = new System.Drawing.Point(162, 188);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(130, 35);
            this.btnPagamento.TabIndex = 11;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(162, 133);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(130, 35);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Fechar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(20, 133);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(130, 35);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // chkQuilo
            // 
            this.chkQuilo.AutoSize = true;
            this.chkQuilo.Location = new System.Drawing.Point(205, 95);
            this.chkQuilo.Name = "chkQuilo";
            this.chkQuilo.Size = new System.Drawing.Size(80, 21);
            this.chkQuilo.TabIndex = 8;
            this.chkQuilo.Text = "Por quilo";
            this.chkQuilo.UseVisualStyleBackColor = true;
            this.chkQuilo.CheckedChanged += new System.EventHandler(this.cbxQuilo_CheckedChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(67, 93);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(84, 25);
            this.txtPeso.TabIndex = 7;
            this.txtPeso.Visible = false;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(25, 96);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(36, 17);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Visible = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(205, 62);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(104, 25);
            this.txtQuantidade.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(162, 65);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(37, 17);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Qntd";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(67, 62);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(84, 25);
            this.txtPreco.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(20, 65);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(41, 17);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(67, 31);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(242, 25);
            this.txtProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 34);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(55, 17);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // groupBoxRemover
            // 
            this.groupBoxRemover.Controls.Add(this.label1);
            this.groupBoxRemover.Controls.Add(this.btnRemover);
            this.groupBoxRemover.Controls.Add(this.cbxRemover);
            this.groupBoxRemover.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRemover.Location = new System.Drawing.Point(13, 452);
            this.groupBoxRemover.Name = "groupBoxRemover";
            this.groupBoxRemover.Size = new System.Drawing.Size(315, 109);
            this.groupBoxRemover.TabIndex = 4;
            this.groupBoxRemover.TabStop = false;
            this.groupBoxRemover.Text = "  Remover Produto  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caso não selecionar o elemento será removido o primeiro";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(179, 68);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(130, 35);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cbxRemover
            // 
            this.cbxRemover.DropDownHeight = 100;
            this.cbxRemover.FormattingEnabled = true;
            this.cbxRemover.IntegralHeight = false;
            this.cbxRemover.Location = new System.Drawing.Point(6, 24);
            this.cbxRemover.Name = "cbxRemover";
            this.cbxRemover.Size = new System.Drawing.Size(303, 25);
            this.cbxRemover.TabIndex = 0;
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(71, 175);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(256, 23);
            this.cbxUsuario.TabIndex = 6;
            this.cbxUsuario.SelectedIndexChanged += new System.EventHandler(this.cbxUsuario_SelectedIndexChanged);
            // 
            // txtNotinha
            // 
            this.txtNotinha.Location = new System.Drawing.Point(342, 12);
            this.txtNotinha.Multiline = true;
            this.txtNotinha.Name = "txtNotinha";
            this.txtNotinha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotinha.Size = new System.Drawing.Size(276, 508);
            this.txtNotinha.TabIndex = 8;
            // 
            // lblNotinha
            // 
            this.lblNotinha.AutoSize = true;
            this.lblNotinha.Location = new System.Drawing.Point(353, 15);
            this.lblNotinha.Name = "lblNotinha";
            this.lblNotinha.Size = new System.Drawing.Size(204, 15);
            this.lblNotinha.TabIndex = 9;
            this.lblNotinha.Text = "**** GRANDÃO SUPERMERCADO ****";
            // 
            // btnVerificarLucro
            // 
            this.btnVerificarLucro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerificarLucro.Location = new System.Drawing.Point(487, 526);
            this.btnVerificarLucro.Name = "btnVerificarLucro";
            this.btnVerificarLucro.Size = new System.Drawing.Size(131, 35);
            this.btnVerificarLucro.TabIndex = 10;
            this.btnVerificarLucro.Text = "Verificar Lucro";
            this.btnVerificarLucro.UseVisualStyleBackColor = true;
            this.btnVerificarLucro.Click += new System.EventHandler(this.btnVerificarLicro_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Enabled = false;
            this.btnNovoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovoCliente.Location = new System.Drawing.Point(342, 526);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(131, 35);
            this.btnNovoCliente.TabIndex = 11;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // frmHipermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 573);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnVerificarLucro);
            this.Controls.Add(this.lblNotinha);
            this.Controls.Add(this.txtNotinha);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.groupBoxRemover);
            this.Controls.Add(this.groupBoxCaixa);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHipermercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCaixa.ResumeLayout(false);
            this.groupBoxCaixa.PerformLayout();
            this.groupBoxRemover.ResumeLayout(false);
            this.groupBoxRemover.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupBoxCaixa;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox chkQuilo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.GroupBox groupBoxRemover;
        private System.Windows.Forms.ComboBox cbxRemover;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.TextBox txtNotinha;
        private System.Windows.Forms.Label lblNotinha;
        private System.Windows.Forms.Button btnVerificarLucro;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.ComboBox cbxPagamento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label label1;
    }
}

