
namespace QuanLiKhachSan
{
    partial class ManageSchedulesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelMngScheduleShift = new Guna.UI2.WinForms.Guna2Panel();
            this.edit_BT = new Guna.UI2.WinForms.Guna2Button();
            this.timeEnd_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.showSchedule_BT = new Guna.UI2.WinForms.Guna2Button();
            this.timeStart_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shiftName_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.janitor_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recept_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.manage_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.del_BT = new Guna.UI2.WinForms.Guna2Button();
            this.add_BT = new Guna.UI2.WinForms.Guna2Button();
            this.shifts_DGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.schedules_DGV = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.schedule_DGV = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelMngScheduleShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts_DGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedules_DGV)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1512, 876);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMngScheduleShift);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(8, 50);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1496, 818);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Shifts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelMngScheduleShift
            // 
            this.panelMngScheduleShift.Controls.Add(this.edit_BT);
            this.panelMngScheduleShift.Controls.Add(this.timeEnd_TB);
            this.panelMngScheduleShift.Controls.Add(this.showSchedule_BT);
            this.panelMngScheduleShift.Controls.Add(this.timeStart_TB);
            this.panelMngScheduleShift.Controls.Add(this.label7);
            this.panelMngScheduleShift.Controls.Add(this.label6);
            this.panelMngScheduleShift.Controls.Add(this.shiftName_TB);
            this.panelMngScheduleShift.Controls.Add(this.janitor_CBO);
            this.panelMngScheduleShift.Controls.Add(this.label5);
            this.panelMngScheduleShift.Controls.Add(this.recept_CBO);
            this.panelMngScheduleShift.Controls.Add(this.label2);
            this.panelMngScheduleShift.Controls.Add(this.manage_CBO);
            this.panelMngScheduleShift.Controls.Add(this.del_BT);
            this.panelMngScheduleShift.Controls.Add(this.add_BT);
            this.panelMngScheduleShift.Controls.Add(this.shifts_DGV);
            this.panelMngScheduleShift.Controls.Add(this.label3);
            this.panelMngScheduleShift.Controls.Add(this.label4);
            this.panelMngScheduleShift.Location = new System.Drawing.Point(18, 28);
            this.panelMngScheduleShift.Name = "panelMngScheduleShift";
            this.panelMngScheduleShift.ShadowDecoration.Parent = this.panelMngScheduleShift;
            this.panelMngScheduleShift.Size = new System.Drawing.Size(1478, 776);
            this.panelMngScheduleShift.TabIndex = 75;
            // 
            // edit_BT
            // 
            this.edit_BT.BorderRadius = 20;
            this.edit_BT.CheckedState.Parent = this.edit_BT;
            this.edit_BT.CustomImages.Parent = this.edit_BT;
            this.edit_BT.FillColor = System.Drawing.Color.SteelBlue;
            this.edit_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_BT.ForeColor = System.Drawing.Color.White;
            this.edit_BT.HoverState.Parent = this.edit_BT;
            this.edit_BT.Location = new System.Drawing.Point(1198, 34);
            this.edit_BT.Name = "edit_BT";
            this.edit_BT.ShadowDecoration.Parent = this.edit_BT;
            this.edit_BT.Size = new System.Drawing.Size(267, 80);
            this.edit_BT.TabIndex = 105;
            this.edit_BT.Text = "Edit";
            this.edit_BT.Click += new System.EventHandler(this.edit_BT_Click);
            // 
            // timeEnd_TB
            // 
            this.timeEnd_TB.BorderThickness = 3;
            this.timeEnd_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeEnd_TB.DefaultText = "";
            this.timeEnd_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeEnd_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeEnd_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeEnd_TB.DisabledState.Parent = this.timeEnd_TB;
            this.timeEnd_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeEnd_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeEnd_TB.FocusedState.Parent = this.timeEnd_TB;
            this.timeEnd_TB.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeEnd_TB.HoverState.Parent = this.timeEnd_TB;
            this.timeEnd_TB.Location = new System.Drawing.Point(1185, 270);
            this.timeEnd_TB.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.timeEnd_TB.Name = "timeEnd_TB";
            this.timeEnd_TB.PasswordChar = '\0';
            this.timeEnd_TB.PlaceholderText = "";
            this.timeEnd_TB.SelectedText = "";
            this.timeEnd_TB.ShadowDecoration.Parent = this.timeEnd_TB;
            this.timeEnd_TB.Size = new System.Drawing.Size(267, 55);
            this.timeEnd_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.timeEnd_TB.TabIndex = 104;
            // 
            // showSchedule_BT
            // 
            this.showSchedule_BT.BorderRadius = 20;
            this.showSchedule_BT.CheckedState.Parent = this.showSchedule_BT;
            this.showSchedule_BT.CustomImages.Parent = this.showSchedule_BT;
            this.showSchedule_BT.FillColor = System.Drawing.Color.Goldenrod;
            this.showSchedule_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSchedule_BT.ForeColor = System.Drawing.Color.White;
            this.showSchedule_BT.HoverState.Parent = this.showSchedule_BT;
            this.showSchedule_BT.Location = new System.Drawing.Point(1034, 656);
            this.showSchedule_BT.Name = "showSchedule_BT";
            this.showSchedule_BT.ShadowDecoration.Parent = this.showSchedule_BT;
            this.showSchedule_BT.Size = new System.Drawing.Size(267, 80);
            this.showSchedule_BT.TabIndex = 74;
            this.showSchedule_BT.Text = "Generate Schedule";
            this.showSchedule_BT.Click += new System.EventHandler(this.showSchedule_BT_Click);
            // 
            // timeStart_TB
            // 
            this.timeStart_TB.BorderThickness = 3;
            this.timeStart_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeStart_TB.DefaultText = "";
            this.timeStart_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeStart_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeStart_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeStart_TB.DisabledState.Parent = this.timeStart_TB;
            this.timeStart_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeStart_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeStart_TB.FocusedState.Parent = this.timeStart_TB;
            this.timeStart_TB.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeStart_TB.HoverState.Parent = this.timeStart_TB;
            this.timeStart_TB.Location = new System.Drawing.Point(869, 270);
            this.timeStart_TB.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.timeStart_TB.Name = "timeStart_TB";
            this.timeStart_TB.PasswordChar = '\0';
            this.timeStart_TB.PlaceholderText = "";
            this.timeStart_TB.SelectedText = "";
            this.timeStart_TB.ShadowDecoration.Parent = this.timeStart_TB;
            this.timeStart_TB.Size = new System.Drawing.Size(267, 55);
            this.timeStart_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.timeStart_TB.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1179, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 36);
            this.label7.TabIndex = 102;
            this.label7.Text = "Time End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(863, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 36);
            this.label6.TabIndex = 101;
            this.label6.Text = "Time Start";
            // 
            // shiftName_TB
            // 
            this.shiftName_TB.BorderThickness = 3;
            this.shiftName_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shiftName_TB.DefaultText = "";
            this.shiftName_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.shiftName_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.shiftName_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shiftName_TB.DisabledState.Parent = this.shiftName_TB;
            this.shiftName_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shiftName_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shiftName_TB.FocusedState.Parent = this.shiftName_TB;
            this.shiftName_TB.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftName_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shiftName_TB.HoverState.Parent = this.shiftName_TB;
            this.shiftName_TB.Location = new System.Drawing.Point(868, 125);
            this.shiftName_TB.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.shiftName_TB.Name = "shiftName_TB";
            this.shiftName_TB.PasswordChar = '\0';
            this.shiftName_TB.PlaceholderText = "";
            this.shiftName_TB.SelectedText = "";
            this.shiftName_TB.ShadowDecoration.Parent = this.shiftName_TB;
            this.shiftName_TB.Size = new System.Drawing.Size(584, 55);
            this.shiftName_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.shiftName_TB.TabIndex = 100;
            // 
            // janitor_CBO
            // 
            this.janitor_CBO.BackColor = System.Drawing.Color.Transparent;
            this.janitor_CBO.BorderThickness = 3;
            this.janitor_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.janitor_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.janitor_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.janitor_CBO.FocusedState.Parent = this.janitor_CBO;
            this.janitor_CBO.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janitor_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.janitor_CBO.FormattingEnabled = true;
            this.janitor_CBO.HoverState.Parent = this.janitor_CBO;
            this.janitor_CBO.IntegralHeight = false;
            this.janitor_CBO.ItemHeight = 40;
            this.janitor_CBO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.janitor_CBO.ItemsAppearance.Parent = this.janitor_CBO;
            this.janitor_CBO.Location = new System.Drawing.Point(1276, 447);
            this.janitor_CBO.Name = "janitor_CBO";
            this.janitor_CBO.ShadowDecoration.Parent = this.janitor_CBO;
            this.janitor_CBO.Size = new System.Drawing.Size(176, 46);
            this.janitor_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.janitor_CBO.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1270, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 36);
            this.label5.TabIndex = 98;
            this.label5.Text = "Janitor";
            // 
            // recept_CBO
            // 
            this.recept_CBO.BackColor = System.Drawing.Color.Transparent;
            this.recept_CBO.BorderThickness = 3;
            this.recept_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.recept_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recept_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.recept_CBO.FocusedState.Parent = this.recept_CBO;
            this.recept_CBO.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recept_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.recept_CBO.FormattingEnabled = true;
            this.recept_CBO.HoverState.Parent = this.recept_CBO;
            this.recept_CBO.IntegralHeight = false;
            this.recept_CBO.ItemHeight = 40;
            this.recept_CBO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.recept_CBO.ItemsAppearance.Parent = this.recept_CBO;
            this.recept_CBO.Location = new System.Drawing.Point(1071, 447);
            this.recept_CBO.Name = "recept_CBO";
            this.recept_CBO.ShadowDecoration.Parent = this.recept_CBO;
            this.recept_CBO.Size = new System.Drawing.Size(176, 46);
            this.recept_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.recept_CBO.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1065, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 36);
            this.label2.TabIndex = 96;
            this.label2.Text = "Receptionist";
            // 
            // manage_CBO
            // 
            this.manage_CBO.BackColor = System.Drawing.Color.Transparent;
            this.manage_CBO.BorderThickness = 3;
            this.manage_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.manage_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manage_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.manage_CBO.FocusedState.Parent = this.manage_CBO;
            this.manage_CBO.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.manage_CBO.FormattingEnabled = true;
            this.manage_CBO.HoverState.Parent = this.manage_CBO;
            this.manage_CBO.IntegralHeight = false;
            this.manage_CBO.ItemHeight = 40;
            this.manage_CBO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.manage_CBO.ItemsAppearance.Parent = this.manage_CBO;
            this.manage_CBO.Location = new System.Drawing.Point(869, 447);
            this.manage_CBO.Name = "manage_CBO";
            this.manage_CBO.ShadowDecoration.Parent = this.manage_CBO;
            this.manage_CBO.Size = new System.Drawing.Size(176, 46);
            this.manage_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.manage_CBO.TabIndex = 95;
            // 
            // del_BT
            // 
            this.del_BT.BorderRadius = 20;
            this.del_BT.CheckedState.Parent = this.del_BT;
            this.del_BT.CustomImages.Parent = this.del_BT;
            this.del_BT.FillColor = System.Drawing.Color.IndianRed;
            this.del_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_BT.ForeColor = System.Drawing.Color.White;
            this.del_BT.HoverState.Parent = this.del_BT;
            this.del_BT.Location = new System.Drawing.Point(869, 570);
            this.del_BT.Name = "del_BT";
            this.del_BT.ShadowDecoration.Parent = this.del_BT;
            this.del_BT.Size = new System.Drawing.Size(267, 80);
            this.del_BT.TabIndex = 94;
            this.del_BT.Text = "Delete";
            this.del_BT.Click += new System.EventHandler(this.del_BT_Click);
            // 
            // add_BT
            // 
            this.add_BT.BorderRadius = 20;
            this.add_BT.CheckedState.Parent = this.add_BT;
            this.add_BT.CustomImages.Parent = this.add_BT;
            this.add_BT.FillColor = System.Drawing.Color.ForestGreen;
            this.add_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_BT.ForeColor = System.Drawing.Color.White;
            this.add_BT.HoverState.Parent = this.add_BT;
            this.add_BT.Location = new System.Drawing.Point(1198, 570);
            this.add_BT.Name = "add_BT";
            this.add_BT.ShadowDecoration.Parent = this.add_BT;
            this.add_BT.Size = new System.Drawing.Size(267, 80);
            this.add_BT.TabIndex = 93;
            this.add_BT.Text = "Add";
            this.add_BT.Click += new System.EventHandler(this.add_BT_Click);
            // 
            // shifts_DGV
            // 
            this.shifts_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.shifts_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.shifts_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shifts_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shifts_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shifts_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.shifts_DGV.EnableHeadersVisualStyles = false;
            this.shifts_DGV.Location = new System.Drawing.Point(17, 60);
            this.shifts_DGV.Name = "shifts_DGV";
            this.shifts_DGV.RowHeadersVisible = false;
            this.shifts_DGV.RowHeadersWidth = 82;
            this.shifts_DGV.RowTemplate.DividerHeight = 1;
            this.shifts_DGV.RowTemplate.Height = 33;
            this.shifts_DGV.RowTemplate.ReadOnly = true;
            this.shifts_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shifts_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shifts_DGV.Size = new System.Drawing.Size(828, 560);
            this.shifts_DGV.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(863, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 36);
            this.label3.TabIndex = 90;
            this.label3.Text = "Shift Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(863, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 36);
            this.label4.TabIndex = 91;
            this.label4.Text = "Manage";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.schedules_DGV);
            this.tabPage2.Controls.Add(this.guna2Panel1);
            this.tabPage2.Location = new System.Drawing.Point(8, 50);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1496, 818);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Schedules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // schedules_DGV
            // 
            this.schedules_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.schedules_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.schedules_DGV.BackgroundColor = System.Drawing.Color.White;
            this.schedules_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schedules_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.schedules_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schedules_DGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.schedules_DGV.EnableHeadersVisualStyles = false;
            this.schedules_DGV.Location = new System.Drawing.Point(6, 63);
            this.schedules_DGV.Name = "schedules_DGV";
            this.schedules_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schedules_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.schedules_DGV.RowHeadersVisible = false;
            this.schedules_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.schedules_DGV.RowTemplate.DividerHeight = 1;
            this.schedules_DGV.RowTemplate.Height = 33;
            this.schedules_DGV.RowTemplate.ReadOnly = true;
            this.schedules_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.schedules_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.schedules_DGV.Size = new System.Drawing.Size(1301, 762);
            this.schedules_DGV.TabIndex = 76;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.schedule_DGV);
            this.guna2Panel1.Location = new System.Drawing.Point(1313, 63);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(725, 762);
            this.guna2Panel1.TabIndex = 62;
            // 
            // schedule_DGV
            // 
            this.schedule_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schedule_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.schedule_DGV.BackgroundColor = System.Drawing.Color.White;
            this.schedule_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schedule_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schedule_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.schedule_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schedule_DGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.schedule_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedule_DGV.EnableHeadersVisualStyles = false;
            this.schedule_DGV.Location = new System.Drawing.Point(0, 0);
            this.schedule_DGV.Name = "schedule_DGV";
            this.schedule_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schedule_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.schedule_DGV.RowHeadersVisible = false;
            this.schedule_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.schedule_DGV.RowTemplate.DividerHeight = 1;
            this.schedule_DGV.RowTemplate.Height = 33;
            this.schedule_DGV.RowTemplate.ReadOnly = true;
            this.schedule_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.schedule_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schedule_DGV.Size = new System.Drawing.Size(725, 762);
            this.schedule_DGV.TabIndex = 71;
            this.schedule_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_DGV_CellClick);
            // 
            // ManageSchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1512, 876);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSchedulesForm";
            this.Text = "ManageSchedulesForm";
            this.Load += new System.EventHandler(this.ManageSchedulesForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelMngScheduleShift.ResumeLayout(false);
            this.panelMngScheduleShift.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts_DGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedules_DGV)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedule_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView schedule_DGV;
        private Guna.UI2.WinForms.Guna2Button showSchedule_BT;
        private Guna.UI2.WinForms.Guna2Panel panelMngScheduleShift;
        private System.Windows.Forms.DataGridView schedules_DGV;
        private Guna.UI2.WinForms.Guna2Button edit_BT;
        private Guna.UI2.WinForms.Guna2TextBox timeEnd_TB;
        private Guna.UI2.WinForms.Guna2TextBox timeStart_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox shiftName_TB;
        private Guna.UI2.WinForms.Guna2ComboBox janitor_CBO;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox recept_CBO;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox manage_CBO;
        private Guna.UI2.WinForms.Guna2Button del_BT;
        private Guna.UI2.WinForms.Guna2Button add_BT;
        private System.Windows.Forms.DataGridView shifts_DGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}