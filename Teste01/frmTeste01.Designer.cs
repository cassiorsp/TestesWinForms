﻿
namespace Teste01
{
    partial class frmTeste01
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
            this.components = new System.ComponentModel.Container();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tltMsg = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSoma = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHabilitaMulti = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblCalculadora.Location = new System.Drawing.Point(72, 69);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(131, 29);
            this.lblCalculadora.TabIndex = 0;
            this.lblCalculadora.Text = "Calculadora";
            this.lblCalculadora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(53, 242);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(70, 30);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.CalcularAlgo);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(129, 242);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(118, 30);
            this.btnMultiplicacao.TabIndex = 2;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primeiro Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segundo Valor";
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(129, 116);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(163, 27);
            this.txtPrimeiroValor.TabIndex = 6;
            this.txtPrimeiroValor.TextChanged += new System.EventHandler(this.HabilitaBotaoCalcular);
            this.txtPrimeiroValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegrasTxtBox);
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(129, 160);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(163, 27);
            this.txtSegundoValor.TabIndex = 7;
            this.txtSegundoValor.TextChanged += new System.EventHandler(this.HabilitaBotaoCalcular);
            this.txtSegundoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegrasTxtBox);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblResultado.ForeColor = System.Drawing.Color.Green;
            this.lblResultado.Location = new System.Drawing.Point(9, 201);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 23);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // tltMsg
            // 
            this.tltMsg.IsBalloon = true;
            this.tltMsg.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.miHabilitaMulti});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSoma,
            this.multiplicaçãoToolStripMenuItem,
            this.divisãoToolStripMenuItem,
            this.subtraçãoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 23);
            this.toolStripMenuItem1.Text = "Calculo&s";
            // 
            // miSoma
            // 
            this.miSoma.Name = "miSoma";
            this.miSoma.Size = new System.Drawing.Size(146, 22);
            this.miSoma.Text = "Soma";
            this.miSoma.Click += new System.EventHandler(this.CalcularAlgo);
            // 
            // multiplicaçãoToolStripMenuItem
            // 
            this.multiplicaçãoToolStripMenuItem.Name = "multiplicaçãoToolStripMenuItem";
            this.multiplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.multiplicaçãoToolStripMenuItem.Text = "&Multiplicação";
            // 
            // divisãoToolStripMenuItem
            // 
            this.divisãoToolStripMenuItem.Name = "divisãoToolStripMenuItem";
            this.divisãoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.divisãoToolStripMenuItem.Text = "Divisã&o";
            // 
            // subtraçãoToolStripMenuItem
            // 
            this.subtraçãoToolStripMenuItem.Name = "subtraçãoToolStripMenuItem";
            this.subtraçãoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.subtraçãoToolStripMenuItem.Text = "S&ubtração";
            // 
            // miHabilitaMulti
            // 
            this.miHabilitaMulti.Items.AddRange(new object[] {
            "sim",
            "não"});
            this.miHabilitaMulti.Name = "miHabilitaMulti";
            this.miHabilitaMulti.Size = new System.Drawing.Size(121, 23);
            this.miHabilitaMulti.TextChanged += new System.EventHandler(this.HabilitaMultiplicacao);
            // 
            // frmTeste01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(643, 328);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.txtPrimeiroValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTeste01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste 01";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ToolTip tltMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miSoma;
        private System.Windows.Forms.ToolStripMenuItem multiplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox miHabilitaMulti;
    }
}

