namespace Pizzaria.UI
{
    partial class FormPizzaria
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
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.TextBoxEndereco = new System.Windows.Forms.TextBox();
            this.TextBoxTelefone = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.ButtonConfirmar = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(248, 55);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNome.TabIndex = 0;
            this.TextBoxNome.TextChanged += new System.EventHandler(this.TextBoxNome_TextChanged);
            // 
            // TextBoxEndereco
            // 
            this.TextBoxEndereco.Location = new System.Drawing.Point(248, 98);
            this.TextBoxEndereco.Name = "TextBoxEndereco";
            this.TextBoxEndereco.Size = new System.Drawing.Size(100, 20);
            this.TextBoxEndereco.TabIndex = 1;
            this.TextBoxEndereco.TextChanged += new System.EventHandler(this.TextBoxEndereco_TextChanged);
            // 
            // TextBoxTelefone
            // 
            this.TextBoxTelefone.Location = new System.Drawing.Point(248, 150);
            this.TextBoxTelefone.Name = "TextBoxTelefone";
            this.TextBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTelefone.TabIndex = 2;
            this.TextBoxTelefone.TextChanged += new System.EventHandler(this.TextBoxTelefone_TextChanged);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(180, 58);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(38, 13);
            this.LabelNome.TabIndex = 3;
            this.LabelNome.Text = "Nome:";
            // 
            // ButtonConfirmar
            // 
            this.ButtonConfirmar.Location = new System.Drawing.Point(422, 298);
            this.ButtonConfirmar.Name = "ButtonConfirmar";
            this.ButtonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfirmar.TabIndex = 4;
            this.ButtonConfirmar.Text = "Confirmar";
            this.ButtonConfirmar.UseVisualStyleBackColor = true;
            this.ButtonConfirmar.Click += new System.EventHandler(this.ButtonConfirmar_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(329, 298);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelar.TabIndex = 6;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            // 
            // FormPizzaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 333);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonConfirmar);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.TextBoxTelefone);
            this.Controls.Add(this.TextBoxEndereco);
            this.Controls.Add(this.TextBoxNome);
            this.Name = "FormPizzaria";
            this.Text = "FormCadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.TextBox TextBoxEndereco;
        private System.Windows.Forms.TextBox TextBoxTelefone;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Button ButtonConfirmar;
        private System.Windows.Forms.Button ButtonCancelar;
    }
}