namespace AzureIotHub.Explorer.Winforms
{
    partial class Connect
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
            this.label1 = new System.Windows.Forms.Label();
            this.connectionString = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String:";
            // 
            // connectionString
            // 
            this.connectionString.Location = new System.Drawing.Point(114, 36);
            this.connectionString.Multiline = true;
            this.connectionString.Name = "connectionString";
            this.connectionString.Size = new System.Drawing.Size(267, 60);
            this.connectionString.TabIndex = 1;
            this.connectionString.TextChanged += new System.EventHandler(this.OnConnectionStringTextChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(270, 107);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(110, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.OnConnectClick);
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Location = new System.Drawing.Point(12, 13);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(63, 13);
            this.hostNameLabel.TabIndex = 3;
            this.hostNameLabel.Text = "Host Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 142);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.connectionString);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connect";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox connectionString;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}