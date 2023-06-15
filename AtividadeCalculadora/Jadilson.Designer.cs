namespace AtividadeCalculadora
{
    partial class Jadilson
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
            this.components = new System.ComponentModel.Container();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.txtTela = new System.Windows.Forms.TextBox();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tltMsg = new System.Windows.Forms.ToolTip(this.components);
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblHist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdicao.Location = new System.Drawing.Point(15, 78);
            this.btnAdicao.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(90, 30);
            this.btnAdicao.TabIndex = 0;
            this.btnAdicao.Text = "MAIS";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.CalcularAdicao);
            // 
            // txtTela
            // 
            this.txtTela.BackColor = System.Drawing.SystemColors.Info;
            this.txtTela.Location = new System.Drawing.Point(117, 39);
            this.txtTela.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(192, 29);
            this.txtTela.TabIndex = 1;
            this.txtTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTela.TextChanged += new System.EventHandler(this.HabilitaBotoes);
            this.txtTela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegrasTextBox);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.SystemColors.Info;
            this.btnSubtracao.Location = new System.Drawing.Point(117, 78);
            this.btnSubtracao.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(90, 30);
            this.btnSubtracao.TabIndex = 2;
            this.btnSubtracao.Text = "MENOS";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.CalcularSub);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.Info;
            this.btnMultiplicacao.Location = new System.Drawing.Point(321, 78);
            this.btnMultiplicacao.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(90, 30);
            this.btnMultiplicacao.TabIndex = 3;
            this.btnMultiplicacao.Text = "VEZES";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.CalcularMulti);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.SystemColors.Info;
            this.btnDivisao.Location = new System.Drawing.Point(219, 78);
            this.btnDivisao.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(90, 30);
            this.btnDivisao.TabIndex = 4;
            this.btnDivisao.Text = "DIVIDIR";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.CalcularDivi);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.SystemColors.Info;
            this.btnResultado.Location = new System.Drawing.Point(57, 118);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(150, 39);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "IGUAL";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.Calcular);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Info;
            this.btnLimpar.Location = new System.Drawing.Point(219, 118);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 39);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.LimparTudo);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(27, 12);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(123, 22);
            this.lblHistorico.TabIndex = 7;
            this.lblHistorico.Text = "HISTÓRICO:";
            // 
            // lblHist
            // 
            this.lblHist.AutoSize = true;
            this.lblHist.Location = new System.Drawing.Point(158, 12);
            this.lblHist.Name = "lblHist";
            this.lblHist.Size = new System.Drawing.Size(0, 22);
            this.lblHist.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHistorico);
            this.panel1.Controls.Add(this.lblHist);
            this.panel1.Location = new System.Drawing.Point(57, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 84);
            this.panel1.TabIndex = 9;
            // 
            // btnHist
            // 
            this.btnHist.Location = new System.Drawing.Point(139, 165);
            this.btnHist.Name = "btnHist";
            this.btnHist.Size = new System.Drawing.Size(150, 39);
            this.btnHist.TabIndex = 10;
            this.btnHist.Text = "HISTÓRICO";
            this.btnHist.UseVisualStyleBackColor = true;
            this.btnHist.Click += new System.EventHandler(this.btnHist_Click);
            // 
            // Jadilson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 313);
            this.Controls.Add(this.btnHist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.txtTela);
            this.Controls.Add(this.btnAdicao);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(438, 235);
            this.Name = "Jadilson";
            this.Text = "Calculadora JAJA SMART";
            this.Load += new System.EventHandler(this.Jadilson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ToolTip tltMsg;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label lblHist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHist;
    }
}