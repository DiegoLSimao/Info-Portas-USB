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
            this.lblDLSTI = new System.Windows.Forms.Label();
            this.btnDestacar = new System.Windows.Forms.Button();
            this.txtDestacar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbPortaCom
            // 
            this.cmbPortaCom.FormattingEnabled = true;
            this.cmbPortaCom.Location = new System.Drawing.Point(12, 12);
            this.cmbPortaCom.Name = "cmbPortaCom";
            this.cmbPortaCom.Size = new System.Drawing.Size(121, 21);
            this.cmbPortaCom.TabIndex = 0;
            this.cmbPortaCom.SelectedIndexChanged += new System.EventHandler(this.cmbPortaCom_SelectedIndexChanged);
            // 
            // rtbMonitor
            // 
            this.rtbMonitor.Location = new System.Drawing.Point(12, 48);
            this.rtbMonitor.Name = "rtbMonitor";
            this.rtbMonitor.Size = new System.Drawing.Size(776, 336);
            this.rtbMonitor.TabIndex = 1;
            this.rtbMonitor.Text = "";
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(12, 390);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Info Portas";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 390);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDLSTI
            // 
            this.lblDLSTI.AutoSize = true;
            this.lblDLSTI.Location = new System.Drawing.Point(554, 428);
            this.lblDLSTI.Name = "lblDLSTI";
            this.lblDLSTI.Size = new System.Drawing.Size(234, 13);
            this.lblDLSTI.TabIndex = 5;
            this.lblDLSTI.Text = "Diego de Lima Simão Tecnologia da Informação";
            // 
            // btnDestacar
            // 
            this.btnDestacar.Location = new System.Drawing.Point(174, 415);
            this.btnDestacar.Name = "btnDestacar";
            this.btnDestacar.Size = new System.Drawing.Size(75, 23);
            this.btnDestacar.TabIndex = 6;
            this.btnDestacar.Text = "Destacar";
            this.btnDestacar.UseVisualStyleBackColor = true;
            this.btnDestacar.Click += new System.EventHandler(this.btnDestacar_Click);
            // 
            // txtDestacar
            // 
            this.txtDestacar.Location = new System.Drawing.Point(12, 418);
            this.txtDestacar.Name = "txtDestacar";
            this.txtDestacar.Size = new System.Drawing.Size(156, 20);
            this.txtDestacar.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDestacar);
            this.Controls.Add(this.btnDestacar);
            this.Controls.Add(this.lblDLSTI);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.rtbMonitor);
            this.Controls.Add(this.cmbPortaCom);
            this.Name = "frmMain";
            this.Text = "Informações dos dispositivos USB";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPortaCom;
        private System.Windows.Forms.RichTextBox rtbMonitor;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDLSTI;
        private System.Windows.Forms.Button btnDestacar;
        private System.Windows.Forms.TextBox txtDestacar;
    }
}

