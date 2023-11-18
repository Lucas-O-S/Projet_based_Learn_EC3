namespace ProjetilTeste
{
    partial class TelaConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConnect));
            this.StatusConnect = new System.Windows.Forms.Label();
            this.btnSeguir = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.BoxNome = new System.Windows.Forms.TextBox();
            this.boxSenha = new System.Windows.Forms.TextBox();
            this.boxServidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusConnect
            // 
            this.StatusConnect.AutoSize = true;
            this.StatusConnect.Location = new System.Drawing.Point(127, 44);
            this.StatusConnect.Name = "StatusConnect";
            this.StatusConnect.Size = new System.Drawing.Size(35, 13);
            this.StatusConnect.TabIndex = 17;
            this.StatusConnect.Text = "label4";
            this.StatusConnect.Visible = false;
            // 
            // btnSeguir
            // 
            this.btnSeguir.Location = new System.Drawing.Point(130, 195);
            this.btnSeguir.Name = "btnSeguir";
            this.btnSeguir.Size = new System.Drawing.Size(75, 23);
            this.btnSeguir.TabIndex = 16;
            this.btnSeguir.Text = "Seguir";
            this.btnSeguir.UseVisualStyleBackColor = true;
            this.btnSeguir.Click += new System.EventHandler(this.btnSeguir_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 195);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BoxNome
            // 
            this.BoxNome.Location = new System.Drawing.Point(12, 99);
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(100, 20);
            this.BoxNome.TabIndex = 14;
            // 
            // boxSenha
            // 
            this.boxSenha.Location = new System.Drawing.Point(12, 160);
            this.boxSenha.Name = "boxSenha";
            this.boxSenha.Size = new System.Drawing.Size(100, 20);
            this.boxSenha.TabIndex = 13;
            // 
            // boxServidor
            // 
            this.boxServidor.Location = new System.Drawing.Point(12, 41);
            this.boxServidor.Name = "boxServidor";
            this.boxServidor.Size = new System.Drawing.Size(100, 20);
            this.boxServidor.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Servidor";
            // 
            // TelaConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 224);
            this.Controls.Add(this.StatusConnect);
            this.Controls.Add(this.btnSeguir);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.BoxNome);
            this.Controls.Add(this.boxSenha);
            this.Controls.Add(this.boxServidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaConnect";
            this.Text = "Tela de Conexão com BD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusConnect;
        private System.Windows.Forms.Button btnSeguir;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox BoxNome;
        private System.Windows.Forms.TextBox boxSenha;
        private System.Windows.Forms.TextBox boxServidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}