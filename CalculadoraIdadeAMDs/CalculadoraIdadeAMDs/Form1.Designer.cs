namespace CalculadoraIdadeAMDs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tBoxAnoAtual = new System.Windows.Forms.TextBox();
            this.tBoxAnoNasc = new System.Windows.Forms.TextBox();
            this.tBoxSuaIdd = new System.Windows.Forms.TextBox();
            this.tBoxSuaIddMeses = new System.Windows.Forms.TextBox();
            this.tBoxSuaIddDias = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verificando sua idade em anos, meses e dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o ano atual: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o ano de nacimento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sua idade é:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sua idade em meses é:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sua idade em dias é:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(32, 381);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(140, 45);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(239, 381);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(140, 45);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(446, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(140, 45);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tBoxAnoAtual
            // 
            this.tBoxAnoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAnoAtual.Location = new System.Drawing.Point(239, 76);
            this.tBoxAnoAtual.Name = "tBoxAnoAtual";
            this.tBoxAnoAtual.Size = new System.Drawing.Size(92, 30);
            this.tBoxAnoAtual.TabIndex = 9;
            this.tBoxAnoAtual.TextChanged += new System.EventHandler(this.tBoxAnoAtual_TextChanged);
            // 
            // tBoxAnoNasc
            // 
            this.tBoxAnoNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAnoNasc.Location = new System.Drawing.Point(319, 134);
            this.tBoxAnoNasc.Name = "tBoxAnoNasc";
            this.tBoxAnoNasc.Size = new System.Drawing.Size(92, 30);
            this.tBoxAnoNasc.TabIndex = 10;
            this.tBoxAnoNasc.TextChanged += new System.EventHandler(this.tBoxAnoNasc_TextChanged);
            // 
            // tBoxSuaIdd
            // 
            this.tBoxSuaIdd.Enabled = false;
            this.tBoxSuaIdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSuaIdd.Location = new System.Drawing.Point(184, 192);
            this.tBoxSuaIdd.Name = "tBoxSuaIdd";
            this.tBoxSuaIdd.ReadOnly = true;
            this.tBoxSuaIdd.Size = new System.Drawing.Size(92, 30);
            this.tBoxSuaIdd.TabIndex = 11;
            // 
            // tBoxSuaIddMeses
            // 
            this.tBoxSuaIddMeses.Enabled = false;
            this.tBoxSuaIddMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSuaIddMeses.Location = new System.Drawing.Point(287, 250);
            this.tBoxSuaIddMeses.Name = "tBoxSuaIddMeses";
            this.tBoxSuaIddMeses.ReadOnly = true;
            this.tBoxSuaIddMeses.Size = new System.Drawing.Size(92, 30);
            this.tBoxSuaIddMeses.TabIndex = 12;
            // 
            // tBoxSuaIddDias
            // 
            this.tBoxSuaIddDias.Enabled = false;
            this.tBoxSuaIddDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSuaIddDias.Location = new System.Drawing.Point(258, 308);
            this.tBoxSuaIddDias.Name = "tBoxSuaIddDias";
            this.tBoxSuaIddDias.ReadOnly = true;
            this.tBoxSuaIddDias.Size = new System.Drawing.Size(92, 30);
            this.tBoxSuaIddDias.TabIndex = 13;
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxName.Location = new System.Drawing.Point(545, 76);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(225, 30);
            this.tBoxName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadoraIdadeAMDs.Properties.Resources.fotoCam;
            this.pictureBox1.Location = new System.Drawing.Point(563, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(617, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hora:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.tBoxSuaIddDias);
            this.Controls.Add(this.tBoxSuaIddMeses);
            this.Controls.Add(this.tBoxSuaIdd);
            this.Controls.Add(this.tBoxAnoNasc);
            this.Controls.Add(this.tBoxAnoAtual);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificando sua idade";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox tBoxAnoAtual;
        private System.Windows.Forms.TextBox tBoxAnoNasc;
        private System.Windows.Forms.TextBox tBoxSuaIdd;
        private System.Windows.Forms.TextBox tBoxSuaIddMeses;
        private System.Windows.Forms.TextBox tBoxSuaIddDias;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

