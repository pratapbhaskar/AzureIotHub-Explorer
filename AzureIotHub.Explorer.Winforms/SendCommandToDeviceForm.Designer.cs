namespace AzureIotHub.Explorer.Winforms
{
    partial class SendCommandToDeviceForm
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
            this.deviceList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commandText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.encodingList = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device:";
            // 
            // deviceList
            // 
            this.deviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Location = new System.Drawing.Point(71, 10);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(323, 21);
            this.deviceList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // commandText
            // 
            this.commandText.Location = new System.Drawing.Point(71, 64);
            this.commandText.Multiline = true;
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(323, 142);
            this.commandText.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(230, 212);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.OnSendButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encoding:";
            // 
            // encodingList
            // 
            this.encodingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingList.FormattingEnabled = true;
            this.encodingList.Location = new System.Drawing.Point(71, 37);
            this.encodingList.Name = "encodingList";
            this.encodingList.Size = new System.Drawing.Size(323, 21);
            this.encodingList.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(319, 212);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // SendCommandToDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 241);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.encodingList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceList);
            this.Controls.Add(this.label1);
            this.Name = "SendCommandToDeviceForm";
            this.Text = "SendCommandToDeviceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deviceList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox encodingList;
        private System.Windows.Forms.Button closeButton;
    }
}