namespace projSemaforo
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
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRua1 = new System.Windows.Forms.RadioButton();
            this.radRua2 = new System.Windows.Forms.RadioButton();
            this.picRua1 = new System.Windows.Forms.PictureBox();
            this.picRua2 = new System.Windows.Forms.PictureBox();
            this.lblRua1 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRua2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVermelho
            // 
            this.btnVermelho.Location = new System.Drawing.Point(343, 185);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(75, 23);
            this.btnVermelho.TabIndex = 0;
            this.btnVermelho.Text = "Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.Click += new System.EventHandler(this.btnVermelho_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.Location = new System.Drawing.Point(343, 226);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(75, 23);
            this.btnAmarelo.TabIndex = 1;
            this.btnAmarelo.Text = "Amarelo";
            this.btnAmarelo.UseVisualStyleBackColor = true;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(343, 270);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 23);
            this.btnVerde.TabIndex = 2;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRua2);
            this.groupBox1.Controls.Add(this.radRua1);
            this.groupBox1.Location = new System.Drawing.Point(285, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rua";
            // 
            // radRua1
            // 
            this.radRua1.AutoSize = true;
            this.radRua1.Location = new System.Drawing.Point(86, 36);
            this.radRua1.Name = "radRua1";
            this.radRua1.Size = new System.Drawing.Size(31, 17);
            this.radRua1.TabIndex = 0;
            this.radRua1.TabStop = true;
            this.radRua1.Text = "1";
            this.radRua1.UseVisualStyleBackColor = true;
            // 
            // radRua2
            // 
            this.radRua2.AutoSize = true;
            this.radRua2.Location = new System.Drawing.Point(86, 59);
            this.radRua2.Name = "radRua2";
            this.radRua2.Size = new System.Drawing.Size(31, 17);
            this.radRua2.TabIndex = 1;
            this.radRua2.TabStop = true;
            this.radRua2.Text = "2";
            this.radRua2.UseVisualStyleBackColor = true;
            // 
            // picRua1
            // 
            this.picRua1.Image = global::projSemaforo.Properties.Resources.vermelho;
            this.picRua1.Location = new System.Drawing.Point(575, 96);
            this.picRua1.Name = "picRua1";
            this.picRua1.Size = new System.Drawing.Size(125, 197);
            this.picRua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua1.TabIndex = 4;
            this.picRua1.TabStop = false;
            // 
            // picRua2
            // 
            this.picRua2.Image = global::projSemaforo.Properties.Resources.vermelho;
            this.picRua2.Location = new System.Drawing.Point(79, 96);
            this.picRua2.Name = "picRua2";
            this.picRua2.Size = new System.Drawing.Size(125, 197);
            this.picRua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua2.TabIndex = 5;
            this.picRua2.TabStop = false;
            // 
            // lblRua1
            // 
            this.lblRua1.AutoSize = true;
            this.lblRua1.Location = new System.Drawing.Point(623, 42);
            this.lblRua1.Name = "lblRua1";
            this.lblRua1.Size = new System.Drawing.Size(13, 13);
            this.lblRua1.TabIndex = 6;
            this.lblRua1.Text = "0";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(379, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(13, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "0";
            // 
            // lblRua2
            // 
            this.lblRua2.AutoSize = true;
            this.lblRua2.Location = new System.Drawing.Point(121, 42);
            this.lblRua2.Name = "lblRua2";
            this.lblRua2.Size = new System.Drawing.Size(13, 13);
            this.lblRua2.TabIndex = 8;
            this.lblRua2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.lblRua2);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblRua1);
            this.Controls.Add(this.picRua2);
            this.Controls.Add(this.picRua1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnVermelho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRua2;
        private System.Windows.Forms.RadioButton radRua1;
        private System.Windows.Forms.PictureBox picRua1;
        private System.Windows.Forms.PictureBox picRua2;
        private System.Windows.Forms.Label lblRua1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRua2;
    }
}

