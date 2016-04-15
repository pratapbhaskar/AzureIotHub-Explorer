namespace AzureIotHub.Explorer.Winforms
{
    partial class ConnectionStringWindow
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
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.Location = new System.Drawing.Point(12, 9);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(466, 81);
            this.connectionStringLabel.TabIndex = 0;
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Location = new System.Drawing.Point(345, 125);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(133, 23);
            this.copyToClipboardButton.TabIndex = 1;
            this.copyToClipboardButton.Text = "Copy to Clipboard";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.OnCopyToClipBoardButtonClick);
            // 
            // ConnectionStringWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 160);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.connectionStringLabel);
            this.Name = "ConnectionStringWindow";
            this.Text = "ConnectionStringWindows";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label connectionStringLabel;
        private System.Windows.Forms.Button copyToClipboardButton;
    }
}