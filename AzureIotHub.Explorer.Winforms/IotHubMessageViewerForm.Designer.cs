namespace AzureIotHub.Explorer.Winforms
{
    partial class IotHubMessageViewerForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.iotHubNametext = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.messagesList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.iotHubNametext);
            this.splitContainer1.Panel1.Controls.Add(this.startStopButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.messagesList);
            this.splitContainer1.Size = new System.Drawing.Size(793, 445);
            this.splitContainer1.TabIndex = 0;
            // 
            // iotHubNametext
            // 
            this.iotHubNametext.AutoSize = true;
            this.iotHubNametext.Location = new System.Drawing.Point(12, 17);
            this.iotHubNametext.Name = "iotHubNametext";
            this.iotHubNametext.Size = new System.Drawing.Size(35, 13);
            this.iotHubNametext.TabIndex = 1;
            this.iotHubNametext.Text = "label1";
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(706, 12);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 0;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.OnStartStopMessageToggleButtonClick);
            // 
            // messagesList
            // 
            this.messagesList.ContextMenuStrip = this.contextMenuStrip1;
            this.messagesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesList.FormattingEnabled = true;
            this.messagesList.Location = new System.Drawing.Point(0, 0);
            this.messagesList.Name = "messagesList";
            this.messagesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.messagesList.Size = new System.Drawing.Size(793, 391);
            this.messagesList.TabIndex = 0;
            this.messagesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnListBoxKeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // IotHubMessageViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 445);
            this.Controls.Add(this.splitContainer1);
            this.Name = "IotHubMessageViewerForm";
            this.Text = "Azure IotHub Message Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox messagesList;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Label iotHubNametext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}