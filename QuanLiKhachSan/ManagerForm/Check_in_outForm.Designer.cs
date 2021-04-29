
namespace QuanLiKhachSan
{
    partial class Check_in_outForm
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
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emp_id_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.day_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastname_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstname_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.shift_id_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.title_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Check_in_BT = new Guna.UI2.WinForms.Guna2Button();
            this.Check_out_BT = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel_BT = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeight = 40;
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(12, 54);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(765, 394);
            this.dgv.TabIndex = 4;
            this.dgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv.ThemeStyle.RowsStyle.Height = 24;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "dddd MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(356, 38);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1172, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Shift ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(825, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Emp ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(797, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1134, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1196, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Day:";
            // 
            // emp_id_TB
            // 
            this.emp_id_TB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_id_TB.BorderRadius = 10;
            this.emp_id_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emp_id_TB.DefaultText = "";
            this.emp_id_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emp_id_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emp_id_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emp_id_TB.DisabledState.Parent = this.emp_id_TB;
            this.emp_id_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emp_id_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emp_id_TB.FocusedState.Parent = this.emp_id_TB;
            this.emp_id_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emp_id_TB.HoverState.Parent = this.emp_id_TB;
            this.emp_id_TB.Location = new System.Drawing.Point(927, 39);
            this.emp_id_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emp_id_TB.Name = "emp_id_TB";
            this.emp_id_TB.PasswordChar = '\0';
            this.emp_id_TB.PlaceholderText = "";
            this.emp_id_TB.SelectedText = "";
            this.emp_id_TB.ShadowDecoration.Parent = this.emp_id_TB;
            this.emp_id_TB.Size = new System.Drawing.Size(140, 38);
            this.emp_id_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.emp_id_TB.TabIndex = 26;
            // 
            // day_TB
            // 
            this.day_TB.BorderRadius = 10;
            this.day_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.day_TB.DefaultText = "";
            this.day_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.day_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.day_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.day_TB.DisabledState.Parent = this.day_TB;
            this.day_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.day_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.day_TB.FocusedState.Parent = this.day_TB;
            this.day_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.day_TB.HoverState.Parent = this.day_TB;
            this.day_TB.Location = new System.Drawing.Point(1268, 307);
            this.day_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.day_TB.Name = "day_TB";
            this.day_TB.PasswordChar = '\0';
            this.day_TB.PlaceholderText = "";
            this.day_TB.SelectedText = "";
            this.day_TB.ShadowDecoration.Parent = this.day_TB;
            this.day_TB.Size = new System.Drawing.Size(140, 38);
            this.day_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.day_TB.TabIndex = 26;
            // 
            // lastname_TB
            // 
            this.lastname_TB.BorderRadius = 10;
            this.lastname_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname_TB.DefaultText = "";
            this.lastname_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastname_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastname_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastname_TB.DisabledState.Parent = this.lastname_TB;
            this.lastname_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastname_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastname_TB.FocusedState.Parent = this.lastname_TB;
            this.lastname_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastname_TB.HoverState.Parent = this.lastname_TB;
            this.lastname_TB.Location = new System.Drawing.Point(1268, 162);
            this.lastname_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastname_TB.Name = "lastname_TB";
            this.lastname_TB.PasswordChar = '\0';
            this.lastname_TB.PlaceholderText = "";
            this.lastname_TB.SelectedText = "";
            this.lastname_TB.ShadowDecoration.Parent = this.lastname_TB;
            this.lastname_TB.Size = new System.Drawing.Size(140, 38);
            this.lastname_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.lastname_TB.TabIndex = 26;
            // 
            // firstname_TB
            // 
            this.firstname_TB.BorderRadius = 10;
            this.firstname_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname_TB.DefaultText = "";
            this.firstname_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstname_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstname_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstname_TB.DisabledState.Parent = this.firstname_TB;
            this.firstname_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstname_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstname_TB.FocusedState.Parent = this.firstname_TB;
            this.firstname_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstname_TB.HoverState.Parent = this.firstname_TB;
            this.firstname_TB.Location = new System.Drawing.Point(927, 162);
            this.firstname_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstname_TB.Name = "firstname_TB";
            this.firstname_TB.PasswordChar = '\0';
            this.firstname_TB.PlaceholderText = "";
            this.firstname_TB.SelectedText = "";
            this.firstname_TB.ShadowDecoration.Parent = this.firstname_TB;
            this.firstname_TB.Size = new System.Drawing.Size(140, 38);
            this.firstname_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.firstname_TB.TabIndex = 26;
            // 
            // shift_id_TB
            // 
            this.shift_id_TB.BorderRadius = 10;
            this.shift_id_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shift_id_TB.DefaultText = "";
            this.shift_id_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.shift_id_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.shift_id_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shift_id_TB.DisabledState.Parent = this.shift_id_TB;
            this.shift_id_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shift_id_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shift_id_TB.FocusedState.Parent = this.shift_id_TB;
            this.shift_id_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shift_id_TB.HoverState.Parent = this.shift_id_TB;
            this.shift_id_TB.Location = new System.Drawing.Point(1268, 39);
            this.shift_id_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shift_id_TB.Name = "shift_id_TB";
            this.shift_id_TB.PasswordChar = '\0';
            this.shift_id_TB.PlaceholderText = "";
            this.shift_id_TB.SelectedText = "";
            this.shift_id_TB.ShadowDecoration.Parent = this.shift_id_TB;
            this.shift_id_TB.Size = new System.Drawing.Size(140, 38);
            this.shift_id_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.shift_id_TB.TabIndex = 26;
            // 
            // title_TB
            // 
            this.title_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.title_TB.DefaultText = "";
            this.title_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.title_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.title_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.title_TB.DisabledState.Parent = this.title_TB;
            this.title_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.title_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.title_TB.FocusedState.Parent = this.title_TB;
            this.title_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.title_TB.HoverState.Parent = this.title_TB;
            this.title_TB.Location = new System.Drawing.Point(927, 307);
            this.title_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.title_TB.Name = "title_TB";
            this.title_TB.PasswordChar = '\0';
            this.title_TB.PlaceholderText = "";
            this.title_TB.SelectedText = "";
            this.title_TB.ShadowDecoration.Parent = this.title_TB;
            this.title_TB.Size = new System.Drawing.Size(140, 38);
            this.title_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.title_TB.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(859, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Title:";
            // 
            // Check_in_BT
            // 
            this.Check_in_BT.BorderRadius = 20;
            this.Check_in_BT.CheckedState.Parent = this.Check_in_BT;
            this.Check_in_BT.CustomImages.Parent = this.Check_in_BT;
            this.Check_in_BT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Check_in_BT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Check_in_BT.ForeColor = System.Drawing.Color.Black;
            this.Check_in_BT.HoverState.Parent = this.Check_in_BT;
            this.Check_in_BT.Location = new System.Drawing.Point(863, 452);
            this.Check_in_BT.Name = "Check_in_BT";
            this.Check_in_BT.ShadowDecoration.Parent = this.Check_in_BT;
            this.Check_in_BT.Size = new System.Drawing.Size(143, 48);
            this.Check_in_BT.TabIndex = 29;
            this.Check_in_BT.Text = "Check In";
            this.Check_in_BT.Click += new System.EventHandler(this.Check_in_BT_Click);
            // 
            // Check_out_BT
            // 
            this.Check_out_BT.BorderRadius = 20;
            this.Check_out_BT.CheckedState.Parent = this.Check_out_BT;
            this.Check_out_BT.CustomImages.Parent = this.Check_out_BT;
            this.Check_out_BT.FillColor = System.Drawing.Color.Yellow;
            this.Check_out_BT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Check_out_BT.ForeColor = System.Drawing.Color.Black;
            this.Check_out_BT.HoverState.Parent = this.Check_out_BT;
            this.Check_out_BT.Location = new System.Drawing.Point(1066, 452);
            this.Check_out_BT.Name = "Check_out_BT";
            this.Check_out_BT.ShadowDecoration.Parent = this.Check_out_BT;
            this.Check_out_BT.Size = new System.Drawing.Size(143, 48);
            this.Check_out_BT.TabIndex = 30;
            this.Check_out_BT.Text = "Check Out";
            this.Check_out_BT.Click += new System.EventHandler(this.Check_out_BT_Click);
            // 
            // Cancel_BT
            // 
            this.Cancel_BT.BorderRadius = 20;
            this.Cancel_BT.CheckedState.Parent = this.Cancel_BT;
            this.Cancel_BT.CustomImages.Parent = this.Cancel_BT;
            this.Cancel_BT.FillColor = System.Drawing.Color.Red;
            this.Cancel_BT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancel_BT.ForeColor = System.Drawing.Color.Black;
            this.Cancel_BT.HoverState.Parent = this.Cancel_BT;
            this.Cancel_BT.Location = new System.Drawing.Point(1265, 452);
            this.Cancel_BT.Name = "Cancel_BT";
            this.Cancel_BT.ShadowDecoration.Parent = this.Cancel_BT;
            this.Cancel_BT.Size = new System.Drawing.Size(143, 48);
            this.Cancel_BT.TabIndex = 31;
            this.Cancel_BT.Text = "Cancel";
            // 
            // Check_in_outForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1444, 645);
            this.Controls.Add(this.Cancel_BT);
            this.Controls.Add(this.Check_out_BT);
            this.Controls.Add(this.Check_in_BT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.title_TB);
            this.Controls.Add(this.shift_id_TB);
            this.Controls.Add(this.firstname_TB);
            this.Controls.Add(this.lastname_TB);
            this.Controls.Add(this.day_TB);
            this.Controls.Add(this.emp_id_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgv);
            this.Name = "Check_in_outForm";
            this.Text = "Check_in_outForm";
            this.Load += new System.EventHandler(this.Check_in_outForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox emp_id_TB;
        private Guna.UI2.WinForms.Guna2TextBox day_TB;
        private Guna.UI2.WinForms.Guna2TextBox lastname_TB;
        private Guna.UI2.WinForms.Guna2TextBox firstname_TB;
        private Guna.UI2.WinForms.Guna2TextBox shift_id_TB;
        private Guna.UI2.WinForms.Guna2TextBox title_TB;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Check_in_BT;
        private Guna.UI2.WinForms.Guna2Button Check_out_BT;
        private Guna.UI2.WinForms.Guna2Button Cancel_BT;
    }
}