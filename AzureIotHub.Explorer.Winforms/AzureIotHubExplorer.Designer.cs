namespace AzureIotHub.Explorer.Winforms
{
    partial class AzureIotHubExplorer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.deviceList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateConnectionString = new System.Windows.Forms.ToolStripMenuItem();
            this.addDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.sendCommandToDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.refreshCheckbox = new System.Windows.Forms.CheckBox();
            this.openMessageViewerButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceList)).BeginInit();
            this.datagridviewContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // deviceList
            // 
            this.deviceList.AllowUserToDeleteRows = false;
            this.deviceList.AutoGenerateColumns = false;
            this.deviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.deviceList.ContextMenuStrip = this.datagridviewContextMenu;
            this.deviceList.DataSource = this.deviceModelBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deviceList.DefaultCellStyle = dataGridViewCellStyle2;
            this.deviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceList.Location = new System.Drawing.Point(0, 0);
            this.deviceList.Name = "deviceList";
            this.deviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deviceList.Size = new System.Drawing.Size(755, 432);
            this.deviceList.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastActivityTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Activity Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CToDMessageCount";
            this.dataGridViewTextBoxColumn3.HeaderText = "C To D Message Count";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ConnectionState";
            this.dataGridViewTextBoxColumn4.HeaderText = "Connection State";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // datagridviewContextMenu
            // 
            this.datagridviewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateConnectionString,
            this.addDevice,
            this.removeDevice,
            this.sendCommandToDeviceToolStripMenuItem});
            this.datagridviewContextMenu.Name = "datagridviewContextMenu";
            this.datagridviewContextMenu.Size = new System.Drawing.Size(221, 92);
            // 
            // generateConnectionString
            // 
            this.generateConnectionString.Name = "generateConnectionString";
            this.generateConnectionString.Size = new System.Drawing.Size(220, 22);
            this.generateConnectionString.Text = "Generate Connection String";
            this.generateConnectionString.Click += new System.EventHandler(this.OnGenerateConnectionStringClick);
            // 
            // addDevice
            // 
            this.addDevice.Name = "addDevice";
            this.addDevice.Size = new System.Drawing.Size(220, 22);
            this.addDevice.Text = "Add Device";
            this.addDevice.Click += new System.EventHandler(this.OnAddDeviceClick);
            // 
            // removeDevice
            // 
            this.removeDevice.Name = "removeDevice";
            this.removeDevice.Size = new System.Drawing.Size(220, 22);
            this.removeDevice.Text = "Remove Device";
            this.removeDevice.Click += new System.EventHandler(this.OnRemoveDeviceClick);
            // 
            // sendCommandToDeviceToolStripMenuItem
            // 
            this.sendCommandToDeviceToolStripMenuItem.Name = "sendCommandToDeviceToolStripMenuItem";
            this.sendCommandToDeviceToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.sendCommandToDeviceToolStripMenuItem.Text = "Send Command To Device";
            this.sendCommandToDeviceToolStripMenuItem.Click += new System.EventHandler(this.OnSendCommandToDevice);
            // 
            // deviceModelBindingSource1
            // 
            this.deviceModelBindingSource1.DataSource = typeof(AzureIotHub.Explorer.DeviceModel);
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
            this.splitContainer1.Panel1.Controls.Add(this.refreshCheckbox);
            this.splitContainer1.Panel1.Controls.Add(this.openMessageViewerButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deviceList);
            this.splitContainer1.Size = new System.Drawing.Size(755, 475);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 1;
            // 
            // refreshCheckbox
            // 
            this.refreshCheckbox.AutoSize = true;
            this.refreshCheckbox.Location = new System.Drawing.Point(637, 12);
            this.refreshCheckbox.Name = "refreshCheckbox";
            this.refreshCheckbox.Size = new System.Drawing.Size(106, 17);
            this.refreshCheckbox.TabIndex = 1;
            this.refreshCheckbox.Text = "refresh every min";
            this.refreshCheckbox.UseVisualStyleBackColor = true;
            this.refreshCheckbox.CheckedChanged += new System.EventHandler(this.OnRefreshCheckChanged);
            // 
            // openMessageViewerButton
            // 
            this.openMessageViewerButton.Location = new System.Drawing.Point(12, 8);
            this.openMessageViewerButton.Name = "openMessageViewerButton";
            this.openMessageViewerButton.Size = new System.Drawing.Size(135, 23);
            this.openMessageViewerButton.TabIndex = 0;
            this.openMessageViewerButton.Text = "Open Message Viewer";
            this.openMessageViewerButton.UseVisualStyleBackColor = true;
            this.openMessageViewerButton.Click += new System.EventHandler(this.OnOpenMessageViewerButtonClick);
            // 
            // AzureIotHubExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 497);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "AzureIotHubExplorer";
            this.Text = "Azure Iot Hub Explorer";
            this.Load += new System.EventHandler(this.OnLoad);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceList)).EndInit();
            this.datagridviewContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView deviceList;
        private System.Windows.Forms.BindingSource deviceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastActivityTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToDMessageCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip datagridviewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem generateConnectionString;
        private System.Windows.Forms.ToolStripMenuItem addDevice;
        private System.Windows.Forms.ToolStripMenuItem removeDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem sendCommandToDeviceToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button openMessageViewerButton;
        private System.Windows.Forms.CheckBox refreshCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource deviceModelBindingSource1;
    }
}

