namespace Voice_Recognation
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
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnable.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnable.Location = new System.Drawing.Point(108, 69);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(157, 48);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable Voice Recognation";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.Red;
            this.btnDisable.Enabled = false;
            this.btnDisable.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisable.Location = new System.Drawing.Point(108, 139);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(157, 48);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Disable Voice Recognation";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 262);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
    }
}

