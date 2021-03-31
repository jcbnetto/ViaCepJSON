namespace ViaCepJSON
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEstevinho = new System.Windows.Forms.Label();
            this.gpxResultado = new System.Windows.Forms.GroupBox();
            this.txbDDD = new System.Windows.Forms.TextBox();
            this.txbUF = new System.Windows.Forms.TextBox();
            this.txbLocalidade = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txbCEP = new System.Windows.Forms.MaskedTextBox();
            this.gpxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(140, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(81, 20);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Localizar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(31, 11);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 2;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEstevinho
            // 
            this.lblEstevinho.AutoSize = true;
            this.lblEstevinho.Location = new System.Drawing.Point(57, 258);
            this.lblEstevinho.Name = "lblEstevinho";
            this.lblEstevinho.Size = new System.Drawing.Size(118, 13);
            this.lblEstevinho.TabIndex = 3;
            this.lblEstevinho.Text = "JCBrunoNetto Software";
            // 
            // gpxResultado
            // 
            this.gpxResultado.Controls.Add(this.txbDDD);
            this.gpxResultado.Controls.Add(this.txbUF);
            this.gpxResultado.Controls.Add(this.txbLocalidade);
            this.gpxResultado.Controls.Add(this.txbBairro);
            this.gpxResultado.Controls.Add(this.txbComplemento);
            this.gpxResultado.Controls.Add(this.txbLogradouro);
            this.gpxResultado.Controls.Add(this.lblDDD);
            this.gpxResultado.Controls.Add(this.lblUF);
            this.gpxResultado.Controls.Add(this.lblLocalidade);
            this.gpxResultado.Controls.Add(this.lblBairro);
            this.gpxResultado.Controls.Add(this.lblComplemento);
            this.gpxResultado.Controls.Add(this.lblLogradouro);
            this.gpxResultado.Location = new System.Drawing.Point(12, 65);
            this.gpxResultado.Name = "gpxResultado";
            this.gpxResultado.Size = new System.Drawing.Size(225, 190);
            this.gpxResultado.TabIndex = 4;
            this.gpxResultado.TabStop = false;
            this.gpxResultado.Text = "Resultado";
            // 
            // txbDDD
            // 
            this.txbDDD.Location = new System.Drawing.Point(85, 154);
            this.txbDDD.Name = "txbDDD";
            this.txbDDD.ReadOnly = true;
            this.txbDDD.Size = new System.Drawing.Size(134, 20);
            this.txbDDD.TabIndex = 10;
            // 
            // txbUF
            // 
            this.txbUF.Location = new System.Drawing.Point(85, 128);
            this.txbUF.Name = "txbUF";
            this.txbUF.ReadOnly = true;
            this.txbUF.Size = new System.Drawing.Size(134, 20);
            this.txbUF.TabIndex = 9;
            // 
            // txbLocalidade
            // 
            this.txbLocalidade.Location = new System.Drawing.Point(85, 102);
            this.txbLocalidade.Name = "txbLocalidade";
            this.txbLocalidade.ReadOnly = true;
            this.txbLocalidade.Size = new System.Drawing.Size(134, 20);
            this.txbLocalidade.TabIndex = 8;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(85, 76);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.ReadOnly = true;
            this.txbBairro.Size = new System.Drawing.Size(134, 20);
            this.txbBairro.TabIndex = 8;
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(85, 49);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.ReadOnly = true;
            this.txbComplemento.Size = new System.Drawing.Size(134, 20);
            this.txbComplemento.TabIndex = 7;
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Location = new System.Drawing.Point(85, 23);
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.ReadOnly = true;
            this.txbLogradouro.Size = new System.Drawing.Size(134, 20);
            this.txbLogradouro.TabIndex = 6;
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(46, 157);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(34, 13);
            this.lblDDD.TabIndex = 5;
            this.lblDDD.Text = "DDD:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(55, 131);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 4;
            this.lblUF.Text = "UF:";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(17, 105);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidade.TabIndex = 3;
            this.lblLocalidade.Text = "Localidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(42, 79);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 52);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 1;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(15, 26);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(34, 28);
            this.txbCEP.Mask = "00000-000";
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(100, 20);
            this.txbCEP.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 282);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.gpxResultado);
            this.Controls.Add(this.lblEstevinho);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "Form1";
            this.Text = "BUSCA CEP";
            this.gpxResultado.ResumeLayout(false);
            this.gpxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEstevinho;
        private System.Windows.Forms.GroupBox gpxResultado;
        private System.Windows.Forms.TextBox txbDDD;
        private System.Windows.Forms.TextBox txbUF;
        private System.Windows.Forms.TextBox txbLocalidade;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.MaskedTextBox txbCEP;
    }
}

