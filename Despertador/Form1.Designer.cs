namespace Despertador
{
    partial class frmDespertador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespertador));
            this.btnadicionarmusica = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbligado = new System.Windows.Forms.RadioButton();
            this.rdbdesligado = new System.Windows.Forms.RadioButton();
            this.txtmusica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ThoraActual = new System.Windows.Forms.Timer(this.components);
            this.ThoraDesp = new System.Windows.Forms.Timer(this.components);
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.mtbhoradespertar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblhoraActual = new System.Windows.Forms.Label();
            this.lblhoraDespertar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadicionarmusica
            // 
            this.btnadicionarmusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionarmusica.ForeColor = System.Drawing.Color.Black;
            this.btnadicionarmusica.Location = new System.Drawing.Point(381, 175);
            this.btnadicionarmusica.Name = "btnadicionarmusica";
            this.btnadicionarmusica.Size = new System.Drawing.Size(169, 45);
            this.btnadicionarmusica.TabIndex = 0;
            this.btnadicionarmusica.Text = "Adicionar Música";
            this.btnadicionarmusica.UseVisualStyleBackColor = true;
            this.btnadicionarmusica.Click += new System.EventHandler(this.btnadicionarmusica_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.Black;
            this.btnsair.Location = new System.Drawing.Point(70, 400);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(97, 36);
            this.btnsair.TabIndex = 1;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbligado);
            this.groupBox1.Controls.Add(this.rdbdesligado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(359, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // rdbligado
            // 
            this.rdbligado.AutoSize = true;
            this.rdbligado.ForeColor = System.Drawing.Color.Black;
            this.rdbligado.Location = new System.Drawing.Point(21, 57);
            this.rdbligado.Name = "rdbligado";
            this.rdbligado.Size = new System.Drawing.Size(79, 22);
            this.rdbligado.TabIndex = 1;
            this.rdbligado.TabStop = true;
            this.rdbligado.Text = "Ligado";
            this.rdbligado.UseVisualStyleBackColor = true;
            this.rdbligado.CheckedChanged += new System.EventHandler(this.rdbligado_CheckedChanged);
            // 
            // rdbdesligado
            // 
            this.rdbdesligado.AutoSize = true;
            this.rdbdesligado.ForeColor = System.Drawing.Color.Black;
            this.rdbdesligado.Location = new System.Drawing.Point(21, 25);
            this.rdbdesligado.Name = "rdbdesligado";
            this.rdbdesligado.Size = new System.Drawing.Size(104, 22);
            this.rdbdesligado.TabIndex = 0;
            this.rdbdesligado.TabStop = true;
            this.rdbdesligado.Text = "Desligado";
            this.rdbdesligado.UseVisualStyleBackColor = true;
            this.rdbdesligado.CheckedChanged += new System.EventHandler(this.rdbdesligado_CheckedChanged);
            // 
            // txtmusica
            // 
            this.txtmusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmusica.Location = new System.Drawing.Point(70, 75);
            this.txtmusica.Multiline = true;
            this.txtmusica.Name = "txtmusica";
            this.txtmusica.Size = new System.Drawing.Size(502, 28);
            this.txtmusica.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Música";
            // 
            // ThoraActual
            // 
            this.ThoraActual.Enabled = true;
            this.ThoraActual.Tick += new System.EventHandler(this.ThoraActual_Tick);
            // 
            // ThoraDesp
            // 
            this.ThoraDesp.Tick += new System.EventHandler(this.ThoraDesp_Tick);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(359, 450);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(180, 48);
            this.Media.TabIndex = 5;
            this.Media.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // mtbhoradespertar
            // 
            this.mtbhoradespertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbhoradespertar.Location = new System.Drawing.Point(70, 354);
            this.mtbhoradespertar.Mask = "00:00:00";
            this.mtbhoradespertar.Name = "mtbhoradespertar";
            this.mtbhoradespertar.Size = new System.Drawing.Size(198, 24);
            this.mtbhoradespertar.TabIndex = 6;
            this.mtbhoradespertar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Despertar as: (hh:mm:ss)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(67, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora Despertar\r\n";
            // 
            // lblhoraActual
            // 
            this.lblhoraActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblhoraActual.Location = new System.Drawing.Point(67, 175);
            this.lblhoraActual.Name = "lblhoraActual";
            this.lblhoraActual.Size = new System.Drawing.Size(201, 45);
            this.lblhoraActual.TabIndex = 10;
            this.lblhoraActual.Click += new System.EventHandler(this.ThoraDesp_Tick);
            // 
            // lblhoraDespertar
            // 
            this.lblhoraDespertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblhoraDespertar.Location = new System.Drawing.Point(67, 261);
            this.lblhoraDespertar.Name = "lblhoraDespertar";
            this.lblhoraDespertar.Size = new System.Drawing.Size(201, 43);
            this.lblhoraDespertar.TabIndex = 11;
            this.lblhoraDespertar.Click += new System.EventHandler(this.lblhoraDespertar_Click);
            // 
            // frmDespertador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(633, 558);
            this.Controls.Add(this.lblhoraDespertar);
            this.Controls.Add(this.lblhoraActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbhoradespertar);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmusica);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnadicionarmusica);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "frmDespertador";
            this.Text = "Despertador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadicionarmusica;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbligado;
        private System.Windows.Forms.RadioButton rdbdesligado;
        private System.Windows.Forms.TextBox txtmusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer ThoraActual;
        private System.Windows.Forms.Timer ThoraDesp;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.MaskedTextBox mtbhoradespertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblhoraActual;
        private System.Windows.Forms.Label lblhoraDespertar;
    }
}

