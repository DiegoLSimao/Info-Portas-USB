namespace InfoDispositivoUSB
{
    partial class frmMain
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
            this.cmbPortaCom = new System.Windows.Forms.ComboBox();
            this.rtbMonitor = new System.Windows.Forms.RichTextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDestacar = new System.Windows.Forms.Button();
            this.txtDestacar = new System.Windows.Forms.TextBox();
            this.pgbarProgresso = new System.Windows.Forms.ProgressBar();
            this.btnBarraTemporizada = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPortaCom
            // 
            this.cmbPortaCom.FormattingEnabled = true;
            this.cmbPortaCom.Location = new System.Drawing.Point(169, 537);
            this.cmbPortaCom.Name = "cmbPortaCom";
            this.cmbPortaCom.Size = new System.Drawing.Size(121, 21);
            this.cmbPortaCom.TabIndex = 0;
            this.cmbPortaCom.DropDown += new System.EventHandler(this.cmbPortaCom_DropDown);
            this.cmbPortaCom.SelectedIndexChanged += new System.EventHandler(this.cmbPortaCom_SelectedIndexChanged);
            // 
            // rtbMonitor
            // 
            this.rtbMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbMonitor.Location = new System.Drawing.Point(0, 0);
            this.rtbMonitor.Name = "rtbMonitor";
            this.rtbMonitor.Size = new System.Drawing.Size(1086, 527);
            this.rtbMonitor.TabIndex = 1;
            this.rtbMonitor.Text = "";
            this.rtbMonitor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbMonitor_MouseDown);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(7, 535);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Info Portas";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(88, 535);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDestacar
            // 
            this.btnDestacar.Location = new System.Drawing.Point(169, 560);
            this.btnDestacar.Name = "btnDestacar";
            this.btnDestacar.Size = new System.Drawing.Size(75, 23);
            this.btnDestacar.TabIndex = 6;
            this.btnDestacar.Text = "Destacar";
            this.btnDestacar.UseVisualStyleBackColor = true;
            this.btnDestacar.Click += new System.EventHandler(this.btnDestacar_Click);
            // 
            // txtDestacar
            // 
            this.txtDestacar.Location = new System.Drawing.Point(7, 563);
            this.txtDestacar.Name = "txtDestacar";
            this.txtDestacar.Size = new System.Drawing.Size(156, 20);
            this.txtDestacar.TabIndex = 7;
            // 
            // pgbarProgresso
            // 
            this.pgbarProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbarProgresso.Location = new System.Drawing.Point(7, 586);
            this.pgbarProgresso.Name = "pgbarProgresso";
            this.pgbarProgresso.Size = new System.Drawing.Size(1074, 10);
            this.pgbarProgresso.TabIndex = 8;
            // 
            // btnBarraTemporizada
            // 
            this.btnBarraTemporizada.Location = new System.Drawing.Point(250, 560);
            this.btnBarraTemporizada.Name = "btnBarraTemporizada";
            this.btnBarraTemporizada.Size = new System.Drawing.Size(75, 23);
            this.btnBarraTemporizada.TabIndex = 9;
            this.btnBarraTemporizada.Text = "Barra Tempo";
            this.btnBarraTemporizada.UseVisualStyleBackColor = true;
            this.btnBarraTemporizada.Click += new System.EventHandler(this.btnBarraTemporizada_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(369, 541);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(143, 41);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 605);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnBarraTemporizada);
            this.Controls.Add(this.pgbarProgresso);
            this.Controls.Add(this.txtDestacar);
            this.Controls.Add(this.btnDestacar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.rtbMonitor);
            this.Controls.Add(this.cmbPortaCom);
            this.Name = "frmMain";
            this.Text = "Informações dos dispositivos USB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPortaCom;
        private System.Windows.Forms.RichTextBox rtbMonitor;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDestacar;
        private System.Windows.Forms.TextBox txtDestacar;
        private System.Windows.Forms.ProgressBar pgbarProgresso;
        private System.Windows.Forms.Button btnBarraTemporizada;
        private System.Windows.Forms.Button btnConectar;
    }
}

