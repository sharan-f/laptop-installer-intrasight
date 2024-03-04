namespace Intrasight_Laptop_Installer
{
    partial class download_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_install = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(77, 163);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(440, 33);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(222, 246);
            this.btn_download.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(102, 36);
            this.btn_download.TabIndex = 2;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_install
            // 
            this.btn_install.Enabled = false;
            this.btn_install.Location = new System.Drawing.Point(405, 246);
            this.btn_install.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(112, 36);
            this.btn_install.TabIndex = 3;
            this.btn_install.Text = "Install";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the build version:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Downloading 0%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // download_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "download_form";
            this.Text = "Download Installers";
            this.Load += new System.EventHandler(this.download_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Button btn_download;
        private Button btn_install;
        private Label label1;
        private Label label2;
    }
}