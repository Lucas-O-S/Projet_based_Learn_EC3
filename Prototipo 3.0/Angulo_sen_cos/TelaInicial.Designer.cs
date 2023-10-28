
namespace ProjetilTeste
{
    partial class TelaInicial
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
            this.boxAngulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarVel = new System.Windows.Forms.Button();
            this.btnBucarAng = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boxVelocidade = new System.Windows.Forms.TextBox();
            this.btnSimulador = new System.Windows.Forms.Button();
            this.BtnBancoDados = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boxAngulo
            // 
            this.boxAngulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAngulo.Location = new System.Drawing.Point(391, 44);
            this.boxAngulo.Name = "boxAngulo";
            this.boxAngulo.Size = new System.Drawing.Size(100, 20);
            this.boxAngulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angulo";
            // 
            // btnBuscarVel
            // 
            this.btnBuscarVel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarVel.Location = new System.Drawing.Point(497, 44);
            this.btnBuscarVel.Name = "btnBuscarVel";
            this.btnBuscarVel.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarVel.TabIndex = 2;
            this.btnBuscarVel.Text = "Buscar Vel. Ideal";
            this.btnBuscarVel.UseVisualStyleBackColor = true;
            this.btnBuscarVel.Click += new System.EventHandler(this.btnBuscarVel_Click);
            // 
            // btnBucarAng
            // 
            this.btnBucarAng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBucarAng.Location = new System.Drawing.Point(497, 95);
            this.btnBucarAng.Name = "btnBucarAng";
            this.btnBucarAng.Size = new System.Drawing.Size(121, 23);
            this.btnBucarAng.TabIndex = 5;
            this.btnBucarAng.Text = "Buscar Angulo Ideal";
            this.btnBucarAng.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vel. Inicial";
            // 
            // boxVelocidade
            // 
            this.boxVelocidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxVelocidade.Location = new System.Drawing.Point(391, 95);
            this.boxVelocidade.Name = "boxVelocidade";
            this.boxVelocidade.Size = new System.Drawing.Size(100, 20);
            this.boxVelocidade.TabIndex = 3;
            // 
            // btnSimulador
            // 
            this.btnSimulador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimulador.Location = new System.Drawing.Point(286, 157);
            this.btnSimulador.Name = "btnSimulador";
            this.btnSimulador.Size = new System.Drawing.Size(135, 40);
            this.btnSimulador.TabIndex = 6;
            this.btnSimulador.Text = "Simular";
            this.btnSimulador.UseVisualStyleBackColor = true;
            this.btnSimulador.Click += new System.EventHandler(this.btnSimulador_Click);
            // 
            // BtnBancoDados
            // 
            this.BtnBancoDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBancoDados.Location = new System.Drawing.Point(460, 157);
            this.BtnBancoDados.Name = "BtnBancoDados";
            this.BtnBancoDados.Size = new System.Drawing.Size(135, 40);
            this.BtnBancoDados.TabIndex = 7;
            this.BtnBancoDados.Text = "Verificar Resultados Anteriores";
            this.BtnBancoDados.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.Lista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(12, 38);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(268, 160);
            this.Lista.TabIndex = 8;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 231);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.BtnBancoDados);
            this.Controls.Add(this.btnSimulador);
            this.Controls.Add(this.btnBucarAng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxVelocidade);
            this.Controls.Add(this.btnBuscarVel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxAngulo);
            this.Name = "TelaInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxAngulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarVel;
        private System.Windows.Forms.Button btnBucarAng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxVelocidade;
        private System.Windows.Forms.Button btnSimulador;
        private System.Windows.Forms.Button BtnBancoDados;
        private System.Windows.Forms.ListBox Lista;
    }
}