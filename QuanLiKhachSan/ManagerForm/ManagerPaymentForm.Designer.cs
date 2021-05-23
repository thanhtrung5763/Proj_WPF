
namespace QuanLiKhachSan
{
    partial class ManagerPaymentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.export_BT = new Guna.UI2.WinForms.Guna2Button();
            this.dateSelected_DTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.showPay_BT = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.payment_DGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // export_BT
            // 
            this.export_BT.BorderRadius = 20;
            this.export_BT.CheckedState.Parent = this.export_BT;
            this.export_BT.CustomImages.Parent = this.export_BT;
            this.export_BT.FillColor = System.Drawing.Color.SteelBlue;
            this.export_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_BT.ForeColor = System.Drawing.Color.White;
            this.export_BT.HoverState.Parent = this.export_BT;
            this.export_BT.Location = new System.Drawing.Point(12, 682);
            this.export_BT.Name = "export_BT";
            this.export_BT.ShadowDecoration.Parent = this.export_BT;
            this.export_BT.Size = new System.Drawing.Size(1622, 90);
            this.export_BT.TabIndex = 110;
            this.export_BT.Text = "Export To FIle";
            this.export_BT.Click += new System.EventHandler(this.export_BT_Click);
            // 
            // dateSelected_DTP
            // 
            this.dateSelected_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelected_DTP.Location = new System.Drawing.Point(211, 35);
            this.dateSelected_DTP.Name = "dateSelected_DTP";
            this.dateSelected_DTP.Size = new System.Drawing.Size(238, 43);
            this.dateSelected_DTP.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 112;
            this.label1.Text = "Select Date:";
            // 
            // showPay_BT
            // 
            this.showPay_BT.BorderRadius = 20;
            this.showPay_BT.CheckedState.Parent = this.showPay_BT;
            this.showPay_BT.CustomImages.Parent = this.showPay_BT;
            this.showPay_BT.FillColor = System.Drawing.Color.IndianRed;
            this.showPay_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPay_BT.ForeColor = System.Drawing.Color.White;
            this.showPay_BT.HoverState.Parent = this.showPay_BT;
            this.showPay_BT.Location = new System.Drawing.Point(468, 15);
            this.showPay_BT.Name = "showPay_BT";
            this.showPay_BT.ShadowDecoration.Parent = this.showPay_BT;
            this.showPay_BT.Size = new System.Drawing.Size(287, 80);
            this.showPay_BT.TabIndex = 113;
            this.showPay_BT.Text = "Show Payment";
            this.showPay_BT.Click += new System.EventHandler(this.showPay_BT_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showPay_BT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateSelected_DTP);
            this.panel1.Location = new System.Drawing.Point(11, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 116);
            this.panel1.TabIndex = 114;
            // 
            // payment_DGV
            // 
            this.payment_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.payment_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.payment_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payment_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.payment_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payment_DGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.payment_DGV.EnableHeadersVisualStyles = false;
            this.payment_DGV.Location = new System.Drawing.Point(11, 146);
            this.payment_DGV.Name = "payment_DGV";
            this.payment_DGV.RowHeadersVisible = false;
            this.payment_DGV.RowHeadersWidth = 82;
            this.payment_DGV.RowTemplate.DividerHeight = 1;
            this.payment_DGV.RowTemplate.Height = 33;
            this.payment_DGV.RowTemplate.ReadOnly = true;
            this.payment_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payment_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payment_DGV.Size = new System.Drawing.Size(1623, 530);
            this.payment_DGV.TabIndex = 109;
            // 
            // ManagerPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 784);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.export_BT);
            this.Controls.Add(this.payment_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerPaymentForm";
            this.Text = "ManagerPaymentForm";
            this.Load += new System.EventHandler(this.ManagerPaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button export_BT;
        private System.Windows.Forms.DateTimePicker dateSelected_DTP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button showPay_BT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView payment_DGV;
    }
}