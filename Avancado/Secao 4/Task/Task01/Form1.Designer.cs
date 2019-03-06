namespace Task01
{
    partial class Form1
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
            this.btnFazerDownload = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFazerDownload
            // 
            this.btnFazerDownload.Location = new System.Drawing.Point(12, 240);
            this.btnFazerDownload.Name = "btnFazerDownload";
            this.btnFazerDownload.Size = new System.Drawing.Size(260, 47);
            this.btnFazerDownload.TabIndex = 0;
            this.btnFazerDownload.Text = "Fazer Download";
            this.btnFazerDownload.UseVisualStyleBackColor = true;
            this.btnFazerDownload.Click += new System.EventHandler(this.btnFazerDownload_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 39);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(260, 195);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Site:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(47, 10);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(225, 20);
            this.txtSite.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnFazerDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFazerDownload;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSite;
    }
}

