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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DevicesTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CToDMessageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastActivityTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateConnectionString = new System.Windows.Forms.ToolStripMenuItem();
            this.addDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MessagesTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DevicesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.datagridviewContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).BeginInit();
            this.MessagesTab.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DevicesTab);
            this.tabControl1.Controls.Add(this.MessagesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 475);
            this.tabControl1.TabIndex = 1;
            // 
            // DevicesTab
            // 
            this.DevicesTab.Controls.Add(this.dataGridView1);
            this.DevicesTab.Location = new System.Drawing.Point(4, 22);
            this.DevicesTab.Name = "DevicesTab";
            this.DevicesTab.Padding = new System.Windows.Forms.Padding(3);
            this.DevicesTab.Size = new System.Drawing.Size(747, 449);
            this.DevicesTab.TabIndex = 0;
            this.DevicesTab.Text = "Devices";
            this.DevicesTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.statusDataGridViewTextBoxColumn,
            this.ConnectionState,
            this.CToDMessageCount,
            this.LastActivityTime});
            this.dataGridView1.ContextMenuStrip = this.datagridviewContextMenu;
            this.dataGridView1.DataSource = this.deviceModelBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(741, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // ConnectionState
            // 
            this.ConnectionState.DataPropertyName = "ConnectionState";
            this.ConnectionState.HeaderText = "Connection State";
            this.ConnectionState.Name = "ConnectionState";
            // 
            // CToDMessageCount
            // 
            this.CToDMessageCount.DataPropertyName = "CToDMessageCount";
            this.CToDMessageCount.HeaderText = "C To D MessageCount";
            this.CToDMessageCount.Name = "CToDMessageCount";
            // 
            // LastActivityTime
            // 
            this.LastActivityTime.DataPropertyName = "LastActivityTime";
            this.LastActivityTime.HeaderText = "Last Activity Time";
            this.LastActivityTime.Name = "LastActivityTime";
            // 
            // datagridviewContextMenu
            // 
            this.datagridviewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateConnectionString,
            this.addDevice,
            this.removeDevice});
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
            this.addDevice.Click += new System.EventHandler(this.addDevice_Click);
            // 
            // removeDevice
            // 
            this.removeDevice.Name = "removeDevice";
            this.removeDevice.Size = new System.Drawing.Size(220, 22);
            this.removeDevice.Text = "Remove Device";
            // 
            // deviceModelBindingSource
            // 
            this.deviceModelBindingSource.DataSource = typeof(AzureIotHub.Explorer.DeviceModel);
            // 
            // MessagesTab
            // 
            this.MessagesTab.Controls.Add(this.splitContainer1);
            this.MessagesTab.Location = new System.Drawing.Point(4, 22);
            this.MessagesTab.Name = "MessagesTab";
            this.MessagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.MessagesTab.Size = new System.Drawing.Size(747, 449);
            this.MessagesTab.TabIndex = 1;
            this.MessagesTab.Text = "Messages";
            this.MessagesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(741, 443);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnStartStopToggleButtonClick);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(741, 395);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AzureIotHubExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 497);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "AzureIotHubExplorer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AzureIotHubExplorer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.DevicesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.datagridviewContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).EndInit();
            this.MessagesTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DevicesTab;
        private System.Windows.Forms.TabPage MessagesTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deviceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastActivityTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToDMessageCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip datagridviewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem generateConnectionString;
        private System.Windows.Forms.ToolStripMenuItem addDevice;
        private System.Windows.Forms.ToolStripMenuItem removeDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionState;
        private System.Windows.Forms.DataGridViewTextBoxColumn CToDMessageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastActivityTime;
    }
}

