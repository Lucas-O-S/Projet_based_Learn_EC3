
namespace ProjetilTeste
{
    partial class Simulador
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
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.ProjX = new System.Windows.Forms.TextBox();
            this.ProjY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MetY = new System.Windows.Forms.TextBox();
            this.MetX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TempoTotal = new System.Windows.Forms.Label();
            this.TempoSubida = new System.Windows.Forms.Label();
            this.TempoDescida = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Fundo = new System.Windows.Forms.Panel();
            this.ImgProj = new System.Windows.Forms.PictureBox();
            this.ImgMet = new System.Windows.Forms.PictureBox();
            this.Chao = new System.Windows.Forms.PictureBox();
            this.LimiteSuperior = new System.Windows.Forms.PictureBox();
            this.LimiteHorizontal = new System.Windows.Forms.PictureBox();
            this.Fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimiteSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimiteHorizontal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROJETIL";
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.Enabled = false;
            this.Reset.Location = new System.Drawing.Point(767, 374);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "RESETAR";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ProjX
            // 
            this.ProjX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjX.Enabled = false;
            this.ProjX.Location = new System.Drawing.Point(767, 86);
            this.ProjX.Name = "ProjX";
            this.ProjX.Size = new System.Drawing.Size(87, 20);
            this.ProjX.TabIndex = 12;
            // 
            // ProjY
            // 
            this.ProjY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjY.Enabled = false;
            this.ProjY.Location = new System.Drawing.Point(884, 84);
            this.ProjY.Name = "ProjY";
            this.ProjY.Size = new System.Drawing.Size(87, 20);
            this.ProjY.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(857, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(857, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "X";
            // 
            // MetY
            // 
            this.MetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MetY.Enabled = false;
            this.MetY.Location = new System.Drawing.Point(884, 154);
            this.MetY.Name = "MetY";
            this.MetY.Size = new System.Drawing.Size(87, 20);
            this.MetY.TabIndex = 20;
            // 
            // MetX
            // 
            this.MetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MetX.Enabled = false;
            this.MetX.Location = new System.Drawing.Point(767, 156);
            this.MetX.Name = "MetX";
            this.MetX.Size = new System.Drawing.Size(87, 20);
            this.MetX.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "METEORO";
            // 
            // TempoTotal
            // 
            this.TempoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TempoTotal.AutoSize = true;
            this.TempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoTotal.Location = new System.Drawing.Point(763, 200);
            this.TempoTotal.Name = "TempoTotal";
            this.TempoTotal.Size = new System.Drawing.Size(128, 20);
            this.TempoTotal.TabIndex = 23;
            this.TempoTotal.Text = "Tempo Total: 0";
            // 
            // TempoSubida
            // 
            this.TempoSubida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TempoSubida.AutoSize = true;
            this.TempoSubida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoSubida.Location = new System.Drawing.Point(763, 242);
            this.TempoSubida.Name = "TempoSubida";
            this.TempoSubida.Size = new System.Drawing.Size(144, 20);
            this.TempoSubida.TabIndex = 24;
            this.TempoSubida.Text = "Tempo Subida: 0";
            // 
            // TempoDescida
            // 
            this.TempoDescida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TempoDescida.AutoSize = true;
            this.TempoDescida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoDescida.Location = new System.Drawing.Point(763, 285);
            this.TempoDescida.Name = "TempoDescida";
            this.TempoDescida.Size = new System.Drawing.Size(153, 20);
            this.TempoDescida.TabIndex = 25;
            this.TempoDescida.Text = "Tempo Descida: 0";
            // 
            // Resultado
            // 
            this.Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(763, 319);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(96, 20);
            this.Resultado.TabIndex = 26;
            this.Resultado.Text = "Resultado:";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVoltar.Enabled = false;
            this.BtnVoltar.Location = new System.Drawing.Point(884, 374);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 27;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(760, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "1 px = 10m";
            // 
            // Fundo
            // 
            this.Fundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fundo.BackColor = System.Drawing.Color.Transparent;
            this.Fundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fundo.Controls.Add(this.ImgProj);
            this.Fundo.Controls.Add(this.ImgMet);
            this.Fundo.Controls.Add(this.Chao);
            this.Fundo.Location = new System.Drawing.Point(12, 52);
            this.Fundo.Name = "Fundo";
            this.Fundo.Size = new System.Drawing.Size(722, 423);
            this.Fundo.TabIndex = 30;
            // 
            // ImgProj
            // 
            this.ImgProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImgProj.BackColor = System.Drawing.Color.Transparent;
            this.ImgProj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgProj.Image = global::Angulo_sen_cos.Properties.Resources.circulo_preto_21;
            this.ImgProj.Location = new System.Drawing.Point(19, 365);
            this.ImgProj.Margin = new System.Windows.Forms.Padding(0);
            this.ImgProj.Name = "ImgProj";
            this.ImgProj.Size = new System.Drawing.Size(15, 15);
            this.ImgProj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgProj.TabIndex = 35;
            this.ImgProj.TabStop = false;
            // 
            // ImgMet
            // 
            this.ImgMet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgMet.BackColor = System.Drawing.Color.Transparent;
            this.ImgMet.Image = global::Angulo_sen_cos.Properties.Resources.circulo_preto_1;
            this.ImgMet.Location = new System.Drawing.Point(397, 214);
            this.ImgMet.Margin = new System.Windows.Forms.Padding(0);
            this.ImgMet.Name = "ImgMet";
            this.ImgMet.Size = new System.Drawing.Size(25, 25);
            this.ImgMet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgMet.TabIndex = 33;
            this.ImgMet.TabStop = false;
            // 
            // Chao
            // 
            this.Chao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Chao.BackColor = System.Drawing.Color.Transparent;
            this.Chao.Location = new System.Drawing.Point(-1, 397);
            this.Chao.Margin = new System.Windows.Forms.Padding(0);
            this.Chao.Name = "Chao";
            this.Chao.Size = new System.Drawing.Size(722, 13);
            this.Chao.TabIndex = 33;
            this.Chao.TabStop = false;
            this.Chao.Visible = false;
            // 
            // LimiteSuperior
            // 
            this.LimiteSuperior.Location = new System.Drawing.Point(12, 45);
            this.LimiteSuperior.Name = "LimiteSuperior";
            this.LimiteSuperior.Size = new System.Drawing.Size(310, 20);
            this.LimiteSuperior.TabIndex = 34;
            this.LimiteSuperior.TabStop = false;
            this.LimiteSuperior.Visible = false;
            // 
            // LimiteHorizontal
            // 
            this.LimiteHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LimiteHorizontal.Location = new System.Drawing.Point(730, 219);
            this.LimiteHorizontal.Name = "LimiteHorizontal";
            this.LimiteHorizontal.Size = new System.Drawing.Size(24, 244);
            this.LimiteHorizontal.TabIndex = 16;
            this.LimiteHorizontal.TabStop = false;
            this.LimiteHorizontal.Visible = false;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(983, 487);
            this.Controls.Add(this.LimiteSuperior);
            this.Controls.Add(this.Fundo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.TempoDescida);
            this.Controls.Add(this.TempoSubida);
            this.Controls.Add(this.TempoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MetY);
            this.Controls.Add(this.MetX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LimiteHorizontal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjY);
            this.Controls.Add(this.ProjX);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Name = "Simulador";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Fundo.ResumeLayout(false);
            this.Fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimiteSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimiteHorizontal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox ProjX;
        private System.Windows.Forms.TextBox ProjY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox LimiteHorizontal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MetY;
        private System.Windows.Forms.TextBox MetX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TempoTotal;
        private System.Windows.Forms.Label TempoSubida;
        private System.Windows.Forms.Label TempoDescida;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel Fundo;
        private System.Windows.Forms.PictureBox LimiteSuperior;
        private System.Windows.Forms.PictureBox Chao;
        private System.Windows.Forms.PictureBox ImgMet;
        private System.Windows.Forms.PictureBox ImgProj;
    }
}