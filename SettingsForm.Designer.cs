namespace TargetCheck
{
    partial class SettingsForm
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
            this.TXT_ADDRESS = new System.Windows.Forms.TextBox();
            this.LBL_ADDRESS = new System.Windows.Forms.Label();
            this.TXT_PERIOD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_TIMEOUT = new System.Windows.Forms.TextBox();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_ADDRESS
            // 
            this.TXT_ADDRESS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ADDRESS.Location = new System.Drawing.Point(150, 30);
            this.TXT_ADDRESS.Name = "TXT_ADDRESS";
            this.TXT_ADDRESS.Size = new System.Drawing.Size(200, 26);
            this.TXT_ADDRESS.TabIndex = 0;
            this.TXT_ADDRESS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBL_ADDRESS
            // 
            this.LBL_ADDRESS.AutoSize = true;
            this.LBL_ADDRESS.Location = new System.Drawing.Point(45, 33);
            this.LBL_ADDRESS.Name = "LBL_ADDRESS";
            this.LBL_ADDRESS.Size = new System.Drawing.Size(91, 20);
            this.LBL_ADDRESS.TabIndex = 1;
            this.LBL_ADDRESS.Text = "IP Address:";
            this.LBL_ADDRESS.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TXT_PERIOD
            // 
            this.TXT_PERIOD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_PERIOD.Location = new System.Drawing.Point(150, 70);
            this.TXT_PERIOD.Name = "TXT_PERIOD";
            this.TXT_PERIOD.Size = new System.Drawing.Size(200, 26);
            this.TXT_PERIOD.TabIndex = 2;
            this.TXT_PERIOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loop Period:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ping Timeout:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TXT_TIMEOUT
            // 
            this.TXT_TIMEOUT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_TIMEOUT.Location = new System.Drawing.Point(150, 110);
            this.TXT_TIMEOUT.Name = "TXT_TIMEOUT";
            this.TXT_TIMEOUT.Size = new System.Drawing.Size(200, 26);
            this.TXT_TIMEOUT.TabIndex = 4;
            this.TXT_TIMEOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CANCEL.AutoSize = true;
            this.BTN_CANCEL.Location = new System.Drawing.Point(291, 170);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(75, 30);
            this.BTN_CANCEL.TabIndex = 6;
            this.BTN_CANCEL.Text = "Cancel";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_UPDATE.AutoSize = true;
            this.BTN_UPDATE.Location = new System.Drawing.Point(210, 170);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(75, 30);
            this.BTN_UPDATE.TabIndex = 7;
            this.BTN_UPDATE.Text = "Update";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 205);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_TIMEOUT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_PERIOD);
            this.Controls.Add(this.LBL_ADDRESS);
            this.Controls.Add(this.TXT_ADDRESS);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_ADDRESS;
        private System.Windows.Forms.Label LBL_ADDRESS;
        private System.Windows.Forms.TextBox TXT_PERIOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_TIMEOUT;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_UPDATE;
    }
}