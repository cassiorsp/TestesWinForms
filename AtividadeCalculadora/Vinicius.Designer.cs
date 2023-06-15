
namespace AtividadeCalculadora
{
    partial class Vinicius
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vinicius));
            this.cbPrimeiroValor = new System.Windows.Forms.CheckBox();
            this.cbSegundoValor = new System.Windows.Forms.CheckBox();
            this.cbOperacao = new System.Windows.Forms.CheckBox();
            this.calculadora = new System.Windows.Forms.GroupBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.pFases = new System.Windows.Forms.Panel();
            this.lblResultadoHist = new System.Windows.Forms.Label();
            this.cbResultado = new System.Windows.Forms.CheckBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btResultado = new System.Windows.Forms.Button();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.operacao = new System.Windows.Forms.Label();
            this.lbSegundoValor = new System.Windows.Forms.Label();
            this.lbPrimeiroValor = new System.Windows.Forms.Label();
            this.valores = new System.Windows.Forms.TextBox();
            this.tltMsg = new System.Windows.Forms.ToolTip(this.components);
            this.lbSequencia = new System.Windows.Forms.Label();
            this.lbHistorico = new System.Windows.Forms.Label();
            this.calculadora.SuspendLayout();
            this.pFases.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPrimeiroValor
            // 
            this.cbPrimeiroValor.AutoCheck = false;
            this.cbPrimeiroValor.AutoSize = true;
            this.cbPrimeiroValor.Location = new System.Drawing.Point(7, 6);
            this.cbPrimeiroValor.Name = "cbPrimeiroValor";
            this.cbPrimeiroValor.Size = new System.Drawing.Size(115, 20);
            this.cbPrimeiroValor.TabIndex = 0;
            this.cbPrimeiroValor.Text = "Primeiro Valor";
            this.cbPrimeiroValor.UseVisualStyleBackColor = true;
            this.cbPrimeiroValor.CheckedChanged += new System.EventHandler(this.checkPrimeiroValor);
            // 
            // cbSegundoValor
            // 
            this.cbSegundoValor.AutoCheck = false;
            this.cbSegundoValor.AutoSize = true;
            this.cbSegundoValor.Location = new System.Drawing.Point(7, 31);
            this.cbSegundoValor.Name = "cbSegundoValor";
            this.cbSegundoValor.Size = new System.Drawing.Size(112, 20);
            this.cbSegundoValor.TabIndex = 1;
            this.cbSegundoValor.Text = "Segundo Valor";
            this.cbSegundoValor.UseVisualStyleBackColor = true;
            // 
            // cbOperacao
            // 
            this.cbOperacao.AutoCheck = false;
            this.cbOperacao.AutoSize = true;
            this.cbOperacao.Location = new System.Drawing.Point(7, 57);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Size = new System.Drawing.Size(80, 20);
            this.cbOperacao.TabIndex = 2;
            this.cbOperacao.Text = "Operação";
            this.cbOperacao.UseVisualStyleBackColor = true;
            this.cbOperacao.CheckedChanged += new System.EventHandler(this.clickCheckOperacao);
            this.cbOperacao.CheckStateChanged += new System.EventHandler(this.checkSegundoValor);
            // 
            // calculadora
            // 
            this.calculadora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calculadora.AutoSize = true;
            this.calculadora.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculadora.Controls.Add(this.lbSequencia);
            this.calculadora.Controls.Add(this.lbResultado);
            this.calculadora.Controls.Add(this.pFases);
            this.calculadora.Controls.Add(this.btLimpar);
            this.calculadora.Controls.Add(this.lblResultado);
            this.calculadora.Controls.Add(this.btResultado);
            this.calculadora.Controls.Add(this.rdbDivisao);
            this.calculadora.Controls.Add(this.rdbMultiplicacao);
            this.calculadora.Controls.Add(this.rdbSubtracao);
            this.calculadora.Controls.Add(this.rdbAdicao);
            this.calculadora.Controls.Add(this.operacao);
            this.calculadora.Controls.Add(this.lbSegundoValor);
            this.calculadora.Controls.Add(this.lbPrimeiroValor);
            this.calculadora.Controls.Add(this.valores);
            this.calculadora.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadora.Location = new System.Drawing.Point(47, 12);
            this.calculadora.Margin = new System.Windows.Forms.Padding(0);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(447, 419);
            this.calculadora.TabIndex = 4;
            this.calculadora.TabStop = false;
            this.calculadora.Enter += new System.EventHandler(this.calculadora_Enter);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(156, 156);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(14, 16);
            this.lbResultado.TabIndex = 16;
            this.lbResultado.Text = " ";
            // 
            // pFases
            // 
            this.pFases.Controls.Add(this.lbHistorico);
            this.pFases.Controls.Add(this.lblResultadoHist);
            this.pFases.Controls.Add(this.cbResultado);
            this.pFases.Controls.Add(this.cbOperacao);
            this.pFases.Controls.Add(this.cbPrimeiroValor);
            this.pFases.Controls.Add(this.cbSegundoValor);
            this.pFases.Location = new System.Drawing.Point(264, 25);
            this.pFases.Name = "pFases";
            this.pFases.Size = new System.Drawing.Size(177, 370);
            this.pFases.TabIndex = 14;
            this.pFases.Paint += new System.Windows.Forms.PaintEventHandler(this.pFases_Paint);
            // 
            // lblResultadoHist
            // 
            this.lblResultadoHist.AutoSize = true;
            this.lblResultadoHist.Location = new System.Drawing.Point(21, 128);
            this.lblResultadoHist.Name = "lblResultadoHist";
            this.lblResultadoHist.Size = new System.Drawing.Size(0, 16);
            this.lblResultadoHist.TabIndex = 4;
            // 
            // cbResultado
            // 
            this.cbResultado.AutoCheck = false;
            this.cbResultado.AutoSize = true;
            this.cbResultado.Location = new System.Drawing.Point(7, 81);
            this.cbResultado.Name = "cbResultado";
            this.cbResultado.Size = new System.Drawing.Size(86, 20);
            this.cbResultado.TabIndex = 3;
            this.cbResultado.Text = "Resultado";
            this.cbResultado.UseVisualStyleBackColor = true;
            this.cbResultado.CheckedChanged += new System.EventHandler(this.ClickCheckChanged);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(45, 182);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(111, 23);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Novo cálculo";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.clickLimpa);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(149, 156);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 12;
            // 
            // btResultado
            // 
            this.btResultado.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResultado.Location = new System.Drawing.Point(45, 153);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(111, 23);
            this.btResultado.TabIndex = 11;
            this.btResultado.Text = "Resultado";
            this.btResultado.UseVisualStyleBackColor = true;
            this.btResultado.Click += new System.EventHandler(this.calcResultado);
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDivisao.Location = new System.Drawing.Point(152, 109);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(50, 38);
            this.rdbDivisao.TabIndex = 10;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "÷";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            this.rdbDivisao.CheckedChanged += new System.EventHandler(this.ClickCheckChanged);
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMultiplicacao.Location = new System.Drawing.Point(109, 109);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(47, 38);
            this.rdbMultiplicacao.TabIndex = 9;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "x";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            this.rdbMultiplicacao.CheckedChanged += new System.EventHandler(this.ClickCheckChanged);
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSubtracao.Location = new System.Drawing.Point(67, 109);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(46, 38);
            this.rdbSubtracao.TabIndex = 8;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "-";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            this.rdbSubtracao.CheckedChanged += new System.EventHandler(this.ClickCheckChanged);
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdicao.Location = new System.Drawing.Point(22, 109);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(49, 38);
            this.rdbAdicao.TabIndex = 7;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "+";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            this.rdbAdicao.CheckedChanged += new System.EventHandler(this.ClickCheckChanged);
            // 
            // operacao
            // 
            this.operacao.AutoSize = true;
            this.operacao.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacao.Location = new System.Drawing.Point(29, 89);
            this.operacao.Name = "operacao";
            this.operacao.Size = new System.Drawing.Size(157, 17);
            this.operacao.TabIndex = 6;
            this.operacao.Text = "Escolha uma operação";
            // 
            // lbSegundoValor
            // 
            this.lbSegundoValor.AutoSize = true;
            this.lbSegundoValor.Location = new System.Drawing.Point(74, 25);
            this.lbSegundoValor.Name = "lbSegundoValor";
            this.lbSegundoValor.Size = new System.Drawing.Size(59, 16);
            this.lbSegundoValor.TabIndex = 5;
            this.lbSegundoValor.Text = "2º Valor";
            this.lbSegundoValor.Click += new System.EventHandler(this.checkSegundoValor);
            // 
            // lbPrimeiroValor
            // 
            this.lbPrimeiroValor.AutoSize = true;
            this.lbPrimeiroValor.Location = new System.Drawing.Point(74, 25);
            this.lbPrimeiroValor.Name = "lbPrimeiroValor";
            this.lbPrimeiroValor.Size = new System.Drawing.Size(56, 16);
            this.lbPrimeiroValor.TabIndex = 4;
            this.lbPrimeiroValor.Text = "1º Valor";
            this.lbPrimeiroValor.Click += new System.EventHandler(this.lbPrimeiroValor_Click);
            // 
            // valores
            // 
            this.valores.Location = new System.Drawing.Point(44, 51);
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(107, 25);
            this.valores.TabIndex = 3;
            this.valores.TextChanged += new System.EventHandler(this.HabilitaBotaoResultado);
            this.valores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox);
            // 
            // lbSequencia
            // 
            this.lbSequencia.AutoSize = true;
            this.lbSequencia.Location = new System.Drawing.Point(19, 25);
            this.lbSequencia.Name = "lbSequencia";
            this.lbSequencia.Size = new System.Drawing.Size(167, 16);
            this.lbSequencia.TabIndex = 17;
            this.lbSequencia.Text = "Aperte o botão Resultado";
            // 
            // lbHistorico
            // 
            this.lbHistorico.AutoSize = true;
            this.lbHistorico.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistorico.Location = new System.Drawing.Point(21, 106);
            this.lbHistorico.Name = "lbHistorico";
            this.lbHistorico.Size = new System.Drawing.Size(76, 17);
            this.lbHistorico.TabIndex = 5;
            this.lbHistorico.Text = "Histórico:";
            // 
            // Vinicius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 562);
            this.Controls.Add(this.calculadora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vinicius";
            this.Text = "Vinicius";
            this.calculadora.ResumeLayout(false);
            this.calculadora.PerformLayout();
            this.pFases.ResumeLayout(false);
            this.pFases.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPrimeiroValor;
        private System.Windows.Forms.CheckBox cbSegundoValor;
        private System.Windows.Forms.CheckBox cbOperacao;
        private System.Windows.Forms.GroupBox calculadora;
        private System.Windows.Forms.Label lbSegundoValor;
        private System.Windows.Forms.Label lbPrimeiroValor;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Label operacao;
        private System.Windows.Forms.ToolTip tltMsg;
        private System.Windows.Forms.Panel pFases;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.CheckBox cbResultado;
        private System.Windows.Forms.Label lblResultadoHist;
        private System.Windows.Forms.TextBox valores;
        private System.Windows.Forms.Label lbSequencia;
        private System.Windows.Forms.Label lbHistorico;
    }
}