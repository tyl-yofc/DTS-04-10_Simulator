﻿namespace DTS
{
    partial class EquipMange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_ChannelInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.端口号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_AddRow = new DevComponents.DotNetBar.ButtonX();
            this.bt_RemoveRow = new DevComponents.DotNetBar.ButtonX();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ChannelInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ChannelInfo
            // 
            this.DGV_ChannelInfo.AllowUserToAddRows = false;
            this.DGV_ChannelInfo.AllowUserToResizeColumns = false;
            this.DGV_ChannelInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_ChannelInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_ChannelInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_ChannelInfo.CausesValidation = false;
            this.DGV_ChannelInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ChannelInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_ChannelInfo.ColumnHeadersHeight = 25;
            this.DGV_ChannelInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_ChannelInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.端口号});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ChannelInfo.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_ChannelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_ChannelInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGV_ChannelInfo.Location = new System.Drawing.Point(0, 0);
            this.DGV_ChannelInfo.MultiSelect = false;
            this.DGV_ChannelInfo.Name = "DGV_ChannelInfo";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ChannelInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DGV_ChannelInfo.RowHeadersWidth = 40;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_ChannelInfo.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_ChannelInfo.RowTemplate.Height = 25;
            this.DGV_ChannelInfo.Size = new System.Drawing.Size(459, 226);
            this.DGV_ChannelInfo.TabIndex = 0;
            this.DGV_ChannelInfo.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_ChannelInfo_EditingControlShowing);
            this.DGV_ChannelInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_ChannelInfo_RowPostPaint);
            // 
            // Column1
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column1.HeaderText = "设备编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.HeaderText = "通道个数";
            this.Column2.Name = "Column2";
            this.Column2.Width = 108;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "采样间隔";
            this.Column3.Name = "Column3";
            // 
            // 端口号
            // 
            this.端口号.HeaderText = "端口号";
            this.端口号.Name = "端口号";
            this.端口号.Width = 98;
            // 
            // bt_AddRow
            // 
            this.bt_AddRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_AddRow.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.bt_AddRow.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_AddRow.Location = new System.Drawing.Point(276, 229);
            this.bt_AddRow.Name = "bt_AddRow";
            this.bt_AddRow.Size = new System.Drawing.Size(35, 23);
            this.bt_AddRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_AddRow.TabIndex = 1;
            this.bt_AddRow.Text = "+";
            this.bt_AddRow.Click += new System.EventHandler(this.bt_AddRow_Click);
            // 
            // bt_RemoveRow
            // 
            this.bt_RemoveRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_RemoveRow.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.bt_RemoveRow.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_RemoveRow.Location = new System.Drawing.Point(322, 229);
            this.bt_RemoveRow.Name = "bt_RemoveRow";
            this.bt_RemoveRow.Size = new System.Drawing.Size(30, 23);
            this.bt_RemoveRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_RemoveRow.TabIndex = 2;
            this.bt_RemoveRow.Text = "-";
            this.bt_RemoveRow.Click += new System.EventHandler(this.bt_RemoveRow_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(73, 256);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 3;
            this.bt_Save.Text = "保 存";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(198, 256);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 4;
            this.bt_Cancel.Text = "取 消";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // EquipMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 288);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_RemoveRow);
            this.Controls.Add(this.bt_AddRow);
            this.Controls.Add(this.DGV_ChannelInfo);
            this.Name = "EquipMange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加设备";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EquipMange_FormClosed);
            this.Load += new System.EventHandler(this.EquipMange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ChannelInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGV_ChannelInfo;
        private DevComponents.DotNetBar.ButtonX bt_AddRow;
        private DevComponents.DotNetBar.ButtonX bt_RemoveRow;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 端口号;
    }
}