﻿namespace InfoDispositivoUSB
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
            this.SuspendLayout();
            // 
            // cmbPortaCom
            // 
            this.cmbPortaCom.FormattingEnabled = true;
            this.cmbPortaCom.Location = new System.Drawing.Point(171, 535);
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
            this.rtbMonitor.Size = new System.Drawing.Size(859, 527);
            this.rtbMonitor.TabIndex = 1;
            this.rtbMonitor.Text = "";
            this.rtbMonitor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbMonitor_MouseDown);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(9, 533);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Info Portas";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(90, 533);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDestacar
            // 
            this.btnDestacar.Location = new System.Drawing.Point(171, 558);
            this.btnDestacar.Name = "btnDestacar";
            this.btnDestacar.Size = new System.Drawing.Size(75, 23);
            this.btnDestacar.TabIndex = 6;
            this.btnDestacar.Text = "Destacar";
            this.btnDestacar.UseVisualStyleBackColor = true;
            this.btnDestacar.Click += new System.EventHandler(this.btnDestacar_Click);
            // 
            // txtDestacar
            // 
            this.txtDestacar.Location = new System.Drawing.Point(9, 561);
            this.txtDestacar.Name = "txtDestacar";
            this.txtDestacar.Size = new System.Drawing.Size(156, 20);
            this.txtDestacar.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 593);
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
    }
}

