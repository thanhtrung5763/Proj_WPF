
namespace QuanLiKhachSan
{
    partial class automaticShiftForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(automaticShiftForm));
            this.panelMngShiftSchedule = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.add2_BT = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cancel_BT = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateend_DTP = new System.Windows.Forms.DateTimePicker();
            this.datestart_DTP = new System.Windows.Forms.DateTimePicker();
            this.automaticShift_DGV = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.settingID_CBO = new System.Windows.Forms.ComboBox();
            this.setting_DGV = new System.Windows.Forms.DataGridView();
            this.panelMngShiftSchedule.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticShift_DGV)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMngShiftSchedule
            // 
            this.panelMngShiftSchedule.Controls.Add(this.setting_DGV);
            this.panelMngShiftSchedule.Controls.Add(this.guna2Panel1);
            this.panelMngShiftSchedule.Controls.Add(this.guna2Panel2);
            this.panelMngShiftSchedule.Controls.Add(this.automaticShift_DGV);
            this.panelMngShiftSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMngShiftSchedule.Location = new System.Drawing.Point(0, 0);
            this.panelMngShiftSchedule.Name = "panelMngShiftSchedule";
            this.panelMngShiftSchedule.ShadowDecoration.Parent = this.panelMngShiftSchedule;
            this.panelMngShiftSchedule.Size = new System.Drawing.Size(1708, 764);
            this.panelMngShiftSchedule.TabIndex = 78;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Linen;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.add2_BT);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.cancel_BT);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.dateend_DTP);
            this.guna2Panel2.Controls.Add(this.datestart_DTP);
            this.guna2Panel2.Location = new System.Drawing.Point(436, 555);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1260, 197);
            this.guna2Panel2.TabIndex = 79;
            // 
            // add2_BT
            // 
            this.add2_BT.BorderRadius = 20;
            this.add2_BT.CheckedState.Parent = this.add2_BT;
            this.add2_BT.CustomImages.Parent = this.add2_BT;
            this.add2_BT.FillColor = System.Drawing.Color.ForestGreen;
            this.add2_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add2_BT.ForeColor = System.Drawing.Color.White;
            this.add2_BT.HoverState.Parent = this.add2_BT;
            this.add2_BT.Location = new System.Drawing.Point(981, 18);
            this.add2_BT.Name = "add2_BT";
            this.add2_BT.ShadowDecoration.Parent = this.add2_BT;
            this.add2_BT.Size = new System.Drawing.Size(267, 80);
            this.add2_BT.TabIndex = 94;
            this.add2_BT.Text = "Add";
            this.add2_BT.Click += new System.EventHandler(this.add2_BT_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 36);
            this.label8.TabIndex = 73;
            this.label8.Text = "To:";
            // 
            // cancel_BT
            // 
            this.cancel_BT.BorderRadius = 20;
            this.cancel_BT.CheckedState.Parent = this.cancel_BT;
            this.cancel_BT.CustomImages.Parent = this.cancel_BT;
            this.cancel_BT.FillColor = System.Drawing.Color.Peru;
            this.cancel_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_BT.ForeColor = System.Drawing.Color.White;
            this.cancel_BT.HoverState.Parent = this.cancel_BT;
            this.cancel_BT.Location = new System.Drawing.Point(981, 104);
            this.cancel_BT.Name = "cancel_BT";
            this.cancel_BT.ShadowDecoration.Parent = this.cancel_BT;
            this.cancel_BT.Size = new System.Drawing.Size(267, 80);
            this.cancel_BT.TabIndex = 81;
            this.cancel_BT.Text = "Cancel";
            this.cancel_BT.Click += new System.EventHandler(this.cancel_BT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 72;
            this.label1.Text = "From:";
            // 
            // dateend_DTP
            // 
            this.dateend_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateend_DTP.Location = new System.Drawing.Point(639, 74);
            this.dateend_DTP.Name = "dateend_DTP";
            this.dateend_DTP.Size = new System.Drawing.Size(238, 43);
            this.dateend_DTP.TabIndex = 70;
            // 
            // datestart_DTP
            // 
            this.datestart_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datestart_DTP.Location = new System.Drawing.Point(201, 74);
            this.datestart_DTP.Name = "datestart_DTP";
            this.datestart_DTP.Size = new System.Drawing.Size(238, 43);
            this.datestart_DTP.TabIndex = 69;
            // 
            // automaticShift_DGV
            // 
            this.automaticShift_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.automaticShift_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.automaticShift_DGV.BackgroundColor = System.Drawing.Color.White;
            this.automaticShift_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.automaticShift_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.automaticShift_DGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.automaticShift_DGV.EnableHeadersVisualStyles = false;
            this.automaticShift_DGV.Location = new System.Drawing.Point(436, 12);
            this.automaticShift_DGV.Name = "automaticShift_DGV";
            this.automaticShift_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.automaticShift_DGV.RowHeadersVisible = false;
            this.automaticShift_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.automaticShift_DGV.RowTemplate.DividerHeight = 1;
            this.automaticShift_DGV.RowTemplate.Height = 33;
            this.automaticShift_DGV.RowTemplate.ReadOnly = true;
            this.automaticShift_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.automaticShift_DGV.Size = new System.Drawing.Size(1260, 537);
            this.automaticShift_DGV.TabIndex = 78;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Linen;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.settingID_CBO);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(15, 555);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(415, 197);
            this.guna2Panel1.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 36);
            this.label2.TabIndex = 95;
            this.label2.Text = "Setting ID:";
            // 
            // settingID_CBO
            // 
            this.settingID_CBO.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingID_CBO.FormattingEnabled = true;
            this.settingID_CBO.Location = new System.Drawing.Point(179, 78);
            this.settingID_CBO.Name = "settingID_CBO";
            this.settingID_CBO.Size = new System.Drawing.Size(214, 41);
            this.settingID_CBO.TabIndex = 96;
            this.settingID_CBO.SelectedIndexChanged += new System.EventHandler(this.settingID_CBO_SelectedIndexChanged);
            // 
            // setting_DGV
            // 
            this.setting_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.setting_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.setting_DGV.BackgroundColor = System.Drawing.Color.White;
            this.setting_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.setting_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.setting_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.setting_DGV.EnableHeadersVisualStyles = false;
            this.setting_DGV.Location = new System.Drawing.Point(15, 12);
            this.setting_DGV.Name = "setting_DGV";
            this.setting_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.setting_DGV.RowHeadersVisible = false;
            this.setting_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.setting_DGV.RowTemplate.DividerHeight = 1;
            this.setting_DGV.RowTemplate.Height = 33;
            this.setting_DGV.RowTemplate.ReadOnly = true;
            this.setting_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.setting_DGV.Size = new System.Drawing.Size(415, 537);
            this.setting_DGV.TabIndex = 81;
            // 
            // automaticShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1708, 764);
            this.Controls.Add(this.panelMngShiftSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "automaticShiftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.automaticShiftForm_Load);
            this.panelMngShiftSchedule.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticShift_DGV)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMngShiftSchedule;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateend_DTP;
        private System.Windows.Forms.DateTimePicker datestart_DTP;
        private System.Windows.Forms.DataGridView automaticShift_DGV;
        private Guna.UI2.WinForms.Guna2Button cancel_BT;
        private Guna.UI2.WinForms.Guna2Button add2_BT;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ComboBox settingID_CBO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView setting_DGV;
    }
}