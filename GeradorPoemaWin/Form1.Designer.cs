namespace GeradorPoemaWin
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxPoema = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxLugar = new System.Windows.Forms.TextBox();
            this.textBoxSentimento = new System.Windows.Forms.TextBox();
            this.textBoxQualidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPoema
            // 
            this.comboBoxPoema.FormattingEnabled = true;
            this.comboBoxPoema.Location = new System.Drawing.Point(21, 82);
            this.comboBoxPoema.Name = "comboBoxPoema";
            this.comboBoxPoema.Size = new System.Drawing.Size(339, 24);
            this.comboBoxPoema.TabIndex = 1;
            this.comboBoxPoema.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(21, 153);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(209, 22);
            this.textBoxNome.TabIndex = 2;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLugar
            // 
            this.textBoxLugar.Location = new System.Drawing.Point(21, 209);
            this.textBoxLugar.Name = "textBoxLugar";
            this.textBoxLugar.Size = new System.Drawing.Size(209, 22);
            this.textBoxLugar.TabIndex = 3;
            this.textBoxLugar.TextChanged += new System.EventHandler(this.textBoxLugar_TextChanged);
            // 
            // textBoxSentimento
            // 
            this.textBoxSentimento.Location = new System.Drawing.Point(21, 253);
            this.textBoxSentimento.Name = "textBoxSentimento";
            this.textBoxSentimento.Size = new System.Drawing.Size(209, 22);
            this.textBoxSentimento.TabIndex = 4;
            this.textBoxSentimento.TextChanged += new System.EventHandler(this.textBoxSentimento_TextChanged);
            // 
            // textBoxQualidade
            // 
            this.textBoxQualidade.Location = new System.Drawing.Point(21, 308);
            this.textBoxQualidade.Name = "textBoxQualidade";
            this.textBoxQualidade.Size = new System.Drawing.Size(209, 22);
            this.textBoxQualidade.TabIndex = 5;
            this.textBoxQualidade.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gerar poema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(43, 404);
            this.textBoxResultado.MaximumSize = new System.Drawing.Size(600, 800);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultado.Size = new System.Drawing.Size(600, 200);
            this.textBoxResultado.TabIndex = 20;
            this.textBoxResultado.TabStop = false;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "🌹 Gerador de Poema Romântico 🌹";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "escolha o tipo de poema (1,2,3 ou 4):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(567, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "1-poema classico fofinho     2 - poema Moderno     3 - poema Rimado      4 - poem" +
    "a versão Cria ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Digite o nome da pessoa que eu mais amo(Dica:Ma*ia):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Digite o nome de um lugar especial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Digite um sentimento (ex: amor, saudade):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(475, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Digite uma qualidade sua simples das milhoes que tem(ex: doce , forte , gentil):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxQualidade);
            this.Controls.Add(this.textBoxSentimento);
            this.Controls.Add(this.textBoxLugar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.comboBoxPoema);
            this.Name = "Form1";
            this.Text = "🌹 Gerador de Poema Romântico 🌹";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPoema;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxLugar;
        private System.Windows.Forms.TextBox textBoxSentimento;
        private System.Windows.Forms.TextBox textBoxQualidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

