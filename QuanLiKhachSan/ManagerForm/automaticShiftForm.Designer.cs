
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelMngShiftSchedule.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticShift_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMngShiftSchedule
            // 
            this.panelMngShiftSchedule.Controls.Add(this.guna2Panel2);
            this.panelMngShiftSchedule.Controls.Add(this.automaticShift_DGV);
            this.panelMngShiftSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMngShiftSchedule.Location = new System.Drawing.Point(0, 0);
            this.panelMngShiftSchedule.Name = "panelMngShiftSchedule";
            this.panelMngShiftSchedule.ShadowDecoration.Parent = this.panelMngShiftSchedule;
            this.panelMngShiftSchedule.Size = new System.Drawing.Size(1284, 764);
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
            this.guna2Panel2.Location = new System.Drawing.Point(12, 555);
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.automaticShift_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.automaticShift_DGV.DefaultCellStyle = dataGridViewCellStyle20;
            this.automaticShift_DGV.EnableHeadersVisualStyles = false;
            this.automaticShift_DGV.Location = new System.Drawing.Point(12, 12);
            this.automaticShift_DGV.Name = "automaticShift_DGV";
            this.automaticShift_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.automaticShift_DGV.RowHeadersVisible = false;
            this.automaticShift_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.automaticShift_DGV.RowTemplate.DividerHeight = 1;
            this.automaticShift_DGV.RowTemplate.Height = 33;
            this.automaticShift_DGV.RowTemplate.ReadOnly = true;
            this.automaticShift_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.automaticShift_DGV.Size = new System.Drawing.Size(1260, 522);
            this.automaticShift_DGV.TabIndex = 78;
            // 
            // automaticShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 764);
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
    }
}