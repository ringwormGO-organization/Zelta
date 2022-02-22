namespace Zelta
{
    partial class Settings
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackcolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 79);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(438, 50);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "About Zelta";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 135);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(438, 50);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackcolor);
            this.groupBox1.Location = new System.Drawing.Point(13, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            this.groupBox1.Visible = false;
            // 
            // btnBackcolor
            // 
            this.btnBackcolor.Location = new System.Drawing.Point(6, 21);
            this.btnBackcolor.Name = "btnBackcolor";
            this.btnBackcolor.Size = new System.Drawing.Size(104, 28);
            this.btnBackcolor.TabIndex = 0;
            this.btnBackcolor.Text = "Background";
            this.btnBackcolor.UseVisualStyleBackColor = true;
            this.btnBackcolor.Click += new System.EventHandler(this.btnBackcolor_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackcolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}