
namespace QuanLiKhachSan
{
    partial class mngPaymentInForm
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
            this.history_DGV = new System.Windows.Forms.DataGridView();
            this.tday_BT = new Guna.UI2.WinForms.Guna2Button();
            this.overdue_BT = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.history_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // history_DGV
            // 
            this.history_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.history_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.history_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.history_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.history_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.history_DGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.history_DGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.history_DGV.EnableHeadersVisualStyles = false;
            this.history_DGV.Location = new System.Drawing.Point(12, 12);
            this.history_DGV.Name = "history_DGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.history_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.history_DGV.RowHeadersVisible = false;
            this.history_DGV.RowHeadersWidth = 82;
            this.history_DGV.RowTemplate.DividerHeight = 1;
            this.history_DGV.RowTemplate.Height = 33;
            this.history_DGV.RowTemplate.ReadOnly = true;
            this.history_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.history_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.history_DGV.Size = new System.Drawing.Size(1186, 476);
            this.history_DGV.TabIndex = 111;
            // 
            // tday_BT
            // 
            this.tday_BT.BorderRadius = 20;
            this.tday_BT.CheckedState.Parent = this.tday_BT;
            this.tday_BT.CustomImages.Parent = this.tday_BT;
            this.tday_BT.FillColor = System.Drawing.Color.SteelBlue;
            this.tday_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tday_BT.ForeColor = System.Drawing.Color.White;
            this.tday_BT.HoverState.Parent = this.tday_BT;
            this.tday_BT.Location = new System.Drawing.Point(699, 494);
            this.tday_BT.Name = "tday_BT";
            this.tday_BT.ShadowDecoration.Parent = this.tday_BT;
            this.tday_BT.Size = new System.Drawing.Size(309, 100);
            this.tday_BT.TabIndex = 113;
            this.tday_BT.Text = "Show Today";
            this.tday_BT.Click += new System.EventHandler(this.tday_BT_Click);
            // 
            // overdue_BT
            // 
            this.overdue_BT.BorderRadius = 20;
            this.overdue_BT.CheckedState.Parent = this.overdue_BT;
            this.overdue_BT.CustomImages.Parent = this.overdue_BT;
            this.overdue_BT.FillColor = System.Drawing.Color.ForestGreen;
            this.overdue_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdue_BT.ForeColor = System.Drawing.Color.White;
            this.overdue_BT.HoverState.Parent = this.overdue_BT;
            this.overdue_BT.Location = new System.Drawing.Point(139, 494);
            this.overdue_BT.Name = "overdue_BT";
            this.overdue_BT.ShadowDecoration.Parent = this.overdue_BT;
            this.overdue_BT.Size = new System.Drawing.Size(307, 100);
            this.overdue_BT.TabIndex = 112;
            this.overdue_BT.Text = "Show OverDue";
            this.overdue_BT.Click += new System.EventHandler(this.overdue_BT_Click);
            // 
            // mngPaymentInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 600);
            this.Controls.Add(this.tday_BT);
            this.Controls.Add(this.overdue_BT);
            this.Controls.Add(this.history_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mngPaymentInForm";
            this.Text = "mngPaymentInForm";
            this.Load += new System.EventHandler(this.mngPaymentInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.history_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView history_DGV;
        private Guna.UI2.WinForms.Guna2Button tday_BT;
        private Guna.UI2.WinForms.Guna2Button overdue_BT;
    }
}