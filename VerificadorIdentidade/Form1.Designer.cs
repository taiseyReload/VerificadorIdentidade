namespace VerificadorIdentidade
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
            this.pibVerificador = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.txbAnoNasc = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pibResltado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibVerificador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibResltado)).BeginInit();
            this.SuspendLayout();
            // 
            // pibVerificador
            // 
            this.pibVerificador.BackgroundImage = global::VerificadorIdentidade.Properties.Resources.black;
            this.pibVerificador.Location = new System.Drawing.Point(39, 27);
            this.pibVerificador.Name = "pibVerificador";
            this.pibVerificador.Size = new System.Drawing.Size(330, 334);
            this.pibVerificador.TabIndex = 0;
            this.pibVerificador.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(155, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Verificador";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(54, 88);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(48, 107);
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(174, 32);
            this.txbNome.TabIndex = 3;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.ForeColor = System.Drawing.Color.White;
            this.lblSobrenome.Location = new System.Drawing.Point(54, 153);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(81, 16);
            this.lblSobrenome.TabIndex = 4;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(48, 172);
            this.txbSobrenome.Multiline = true;
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(174, 33);
            this.txbSobrenome.TabIndex = 5;
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.BackColor = System.Drawing.Color.Black;
            this.lblAnoNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoNasc.ForeColor = System.Drawing.Color.White;
            this.lblAnoNasc.Location = new System.Drawing.Point(54, 219);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(88, 16);
            this.lblAnoNasc.TabIndex = 6;
            this.lblAnoNasc.Text = "Ano de Nasc:";
            // 
            // txbAnoNasc
            // 
            this.txbAnoNasc.Location = new System.Drawing.Point(48, 238);
            this.txbAnoNasc.Name = "txbAnoNasc";
            this.txbAnoNasc.Size = new System.Drawing.Size(100, 20);
            this.txbAnoNasc.TabIndex = 7;
            this.txbAnoNasc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.Red;
            this.btnVerificar.Location = new System.Drawing.Point(48, 320);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(108, 32);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpar.Location = new System.Drawing.Point(162, 320);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 32);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(267, 320);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 32);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // pibResltado
            // 
            this.pibResltado.Location = new System.Drawing.Point(390, 27);
            this.pibResltado.Name = "pibResltado";
            this.pibResltado.Size = new System.Drawing.Size(243, 269);
            this.pibResltado.TabIndex = 11;
            this.pibResltado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VerificadorIdentidade.Properties.Resources._178626970;
            this.ClientSize = new System.Drawing.Size(645, 400);
            this.Controls.Add(this.pibResltado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbAnoNasc);
            this.Controls.Add(this.lblAnoNasc);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibVerificador);
            this.Name = "Form1";
            this.Text = "Controle de Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.pibVerificador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibResltado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibVerificador;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.TextBox txbAnoNasc;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pibResltado;
    }
}

