namespace Pizzaria.UI
{
    partial class FormEscolhaPizza
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
            this.ListViewItensPedido = new System.Windows.Forms.ListView();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioPagamentoDinheiro = new System.Windows.Forms.RadioButton();
            this.RadioPagamentoCartao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioEntregaResidencia = new System.Windows.Forms.RadioButton();
            this.RadioEntregaLocal = new System.Windows.Forms.RadioButton();
            this.comboBoxPizza = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.AdicionarPedido = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewItensPedido
            // 
            this.ListViewItensPedido.Location = new System.Drawing.Point(12, 12);
            this.ListViewItensPedido.Name = "ListViewItensPedido";
            this.ListViewItensPedido.Size = new System.Drawing.Size(287, 263);
            this.ListViewItensPedido.TabIndex = 0;
            this.ListViewItensPedido.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Location = new System.Drawing.Point(540, 251);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSalvar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSalvar.TabIndex = 1;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioPagamentoCartao);
            this.groupBox1.Controls.Add(this.RadioPagamentoDinheiro);
            this.groupBox1.Location = new System.Drawing.Point(447, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            // 
            // RadioPagamentoDinheiro
            // 
            this.RadioPagamentoDinheiro.AutoSize = true;
            this.RadioPagamentoDinheiro.Location = new System.Drawing.Point(6, 30);
            this.RadioPagamentoDinheiro.Name = "RadioPagamentoDinheiro";
            this.RadioPagamentoDinheiro.Size = new System.Drawing.Size(64, 17);
            this.RadioPagamentoDinheiro.TabIndex = 0;
            this.RadioPagamentoDinheiro.TabStop = true;
            this.RadioPagamentoDinheiro.Text = "Dinheiro";
            this.RadioPagamentoDinheiro.UseVisualStyleBackColor = true;
            this.RadioPagamentoDinheiro.CheckedChanged += new System.EventHandler(this.RadioPagamentoDinheiro_CheckedChanged);
            // 
            // RadioPagamentoCartao
            // 
            this.RadioPagamentoCartao.AutoSize = true;
            this.RadioPagamentoCartao.Location = new System.Drawing.Point(6, 53);
            this.RadioPagamentoCartao.Name = "RadioPagamentoCartao";
            this.RadioPagamentoCartao.Size = new System.Drawing.Size(56, 17);
            this.RadioPagamentoCartao.TabIndex = 1;
            this.RadioPagamentoCartao.TabStop = true;
            this.RadioPagamentoCartao.Text = "Cartão";
            this.RadioPagamentoCartao.UseVisualStyleBackColor = true;
            this.RadioPagamentoCartao.CheckedChanged += new System.EventHandler(this.RadioPagamentoCartao_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioEntregaResidencia);
            this.groupBox2.Controls.Add(this.RadioEntregaLocal);
            this.groupBox2.Location = new System.Drawing.Point(447, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de Entrega";
            // 
            // RadioEntregaResidencia
            // 
            this.RadioEntregaResidencia.AutoSize = true;
            this.RadioEntregaResidencia.Location = new System.Drawing.Point(6, 53);
            this.RadioEntregaResidencia.Name = "RadioEntregaResidencia";
            this.RadioEntregaResidencia.Size = new System.Drawing.Size(116, 17);
            this.RadioEntregaResidencia.TabIndex = 1;
            this.RadioEntregaResidencia.TabStop = true;
            this.RadioEntregaResidencia.Text = "Entrega a Domicilio";
            this.RadioEntregaResidencia.UseVisualStyleBackColor = true;
            this.RadioEntregaResidencia.CheckedChanged += new System.EventHandler(this.RadioEntregaResidencia_CheckedChanged);
            // 
            // RadioEntregaLocal
            // 
            this.RadioEntregaLocal.AutoSize = true;
            this.RadioEntregaLocal.Location = new System.Drawing.Point(6, 30);
            this.RadioEntregaLocal.Name = "RadioEntregaLocal";
            this.RadioEntregaLocal.Size = new System.Drawing.Size(96, 17);
            this.RadioEntregaLocal.TabIndex = 0;
            this.RadioEntregaLocal.TabStop = true;
            this.RadioEntregaLocal.Text = "Retirar no local";
            this.RadioEntregaLocal.UseVisualStyleBackColor = true;
            this.RadioEntregaLocal.CheckedChanged += new System.EventHandler(this.RadioEntregaLocal_CheckedChanged);
            // 
            // comboBoxPizza
            // 
            this.comboBoxPizza.FormattingEnabled = true;
            this.comboBoxPizza.Location = new System.Drawing.Point(305, 12);
            this.comboBoxPizza.Name = "comboBoxPizza";
            this.comboBoxPizza.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPizza.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(384, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(351, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AdicionarPedido
            // 
            this.AdicionarPedido.Location = new System.Drawing.Point(351, 92);
            this.AdicionarPedido.Name = "AdicionarPedido";
            this.AdicionarPedido.Size = new System.Drawing.Size(75, 23);
            this.AdicionarPedido.TabIndex = 7;
            this.AdicionarPedido.Text = "Adicionar";
            this.AdicionarPedido.UseVisualStyleBackColor = true;
            this.AdicionarPedido.Click += new System.EventHandler(this.AdicionarPedido_Click);
            // 
            // FormEscolhaPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 287);
            this.Controls.Add(this.AdicionarPedido);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBoxPizza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.ListViewItensPedido);
            this.Name = "FormEscolhaPizza";
            this.Text = "FormEscolhaPizza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewItensPedido;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioPagamentoCartao;
        private System.Windows.Forms.RadioButton RadioPagamentoDinheiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioEntregaResidencia;
        private System.Windows.Forms.RadioButton RadioEntregaLocal;
        private System.Windows.Forms.ComboBox comboBoxPizza;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button AdicionarPedido;
    }
}