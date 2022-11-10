namespace PRG282_Project_The_Brain_Cells
{
    partial class UpdateStudent
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
            this.DateStudDOB = new System.Windows.Forms.MaskedTextBox();
            this.cmbGender = new MetroSet_UI.Controls.MetroSetComboBox();
            this.txtAddress = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtStudPhone = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtStudSurname = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtStudName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.cmbNumSelect = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblSelect = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblName = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblNum = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblDOB = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGender = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblPhone = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblAddress = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToAdd = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbxToAdd = new MetroSet_UI.Controls.MetroSetListBox();
            this.lblAdded = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbxCurrent = new MetroSet_UI.Controls.MetroSetListBox();
            this.btnUpdate = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCancel = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // DateStudDOB
            // 
            this.DateStudDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DateStudDOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateStudDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DateStudDOB.Location = new System.Drawing.Point(115, 248);
            this.DateStudDOB.Mask = "00/00/0000";
            this.DateStudDOB.Name = "DateStudDOB";
            this.DateStudDOB.Size = new System.Drawing.Size(217, 20);
            this.DateStudDOB.TabIndex = 56;
            this.DateStudDOB.ValidatingType = typeof(System.DateTime);
            // 
            // cmbGender
            // 
            this.cmbGender.AllowDrop = true;
            this.cmbGender.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbGender.CausesValidation = false;
            this.cmbGender.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbGender.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbGender.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.IsDerivedStyle = true;
            this.cmbGender.ItemHeight = 20;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(465, 242);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbGender.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbGender.Size = new System.Drawing.Size(217, 26);
            this.cmbGender.Style = MetroSet_UI.Enums.Style.Custom;
            this.cmbGender.StyleManager = null;
            this.cmbGender.TabIndex = 55;
            this.cmbGender.ThemeAuthor = "Narwin";
            this.cmbGender.ThemeName = "MetroDark";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoCompleteCustomSource = null;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtAddress.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtAddress.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtAddress.Image = null;
            this.txtAddress.IsDerivedStyle = true;
            this.txtAddress.Lines = null;
            this.txtAddress.Location = new System.Drawing.Point(465, 300);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = false;
            this.txtAddress.Size = new System.Drawing.Size(217, 26);
            this.txtAddress.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtAddress.StyleManager = null;
            this.txtAddress.TabIndex = 54;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.ThemeAuthor = "Narwin";
            this.txtAddress.ThemeName = "MetroDark";
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.WatermarkText = "Enter student\'s Address";
            // 
            // txtStudPhone
            // 
            this.txtStudPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudPhone.AutoCompleteCustomSource = null;
            this.txtStudPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStudPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStudPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtStudPhone.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtStudPhone.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudPhone.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStudPhone.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtStudPhone.Image = null;
            this.txtStudPhone.IsDerivedStyle = true;
            this.txtStudPhone.Lines = null;
            this.txtStudPhone.Location = new System.Drawing.Point(115, 300);
            this.txtStudPhone.MaxLength = 32767;
            this.txtStudPhone.Multiline = false;
            this.txtStudPhone.Name = "txtStudPhone";
            this.txtStudPhone.ReadOnly = false;
            this.txtStudPhone.Size = new System.Drawing.Size(217, 26);
            this.txtStudPhone.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtStudPhone.StyleManager = null;
            this.txtStudPhone.TabIndex = 53;
            this.txtStudPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudPhone.ThemeAuthor = "Narwin";
            this.txtStudPhone.ThemeName = "MetroDark";
            this.txtStudPhone.UseSystemPasswordChar = false;
            this.txtStudPhone.WatermarkText = "Enter student\'s phone number";
            // 
            // txtStudSurname
            // 
            this.txtStudSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudSurname.AutoCompleteCustomSource = null;
            this.txtStudSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStudSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStudSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtStudSurname.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtStudSurname.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudSurname.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStudSurname.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtStudSurname.Image = null;
            this.txtStudSurname.IsDerivedStyle = true;
            this.txtStudSurname.Lines = null;
            this.txtStudSurname.Location = new System.Drawing.Point(465, 189);
            this.txtStudSurname.MaxLength = 32767;
            this.txtStudSurname.Multiline = false;
            this.txtStudSurname.Name = "txtStudSurname";
            this.txtStudSurname.ReadOnly = false;
            this.txtStudSurname.Size = new System.Drawing.Size(217, 26);
            this.txtStudSurname.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtStudSurname.StyleManager = null;
            this.txtStudSurname.TabIndex = 52;
            this.txtStudSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudSurname.ThemeAuthor = "Narwin";
            this.txtStudSurname.ThemeName = "MetroDark";
            this.txtStudSurname.UseSystemPasswordChar = false;
            this.txtStudSurname.WatermarkText = "Enter student\'s surname";
            // 
            // txtStudName
            // 
            this.txtStudName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudName.AutoCompleteCustomSource = null;
            this.txtStudName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStudName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStudName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtStudName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtStudName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStudName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtStudName.Image = null;
            this.txtStudName.IsDerivedStyle = true;
            this.txtStudName.Lines = null;
            this.txtStudName.Location = new System.Drawing.Point(115, 189);
            this.txtStudName.MaxLength = 32767;
            this.txtStudName.Multiline = false;
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.ReadOnly = false;
            this.txtStudName.Size = new System.Drawing.Size(217, 26);
            this.txtStudName.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtStudName.StyleManager = null;
            this.txtStudName.TabIndex = 51;
            this.txtStudName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudName.ThemeAuthor = "Narwin";
            this.txtStudName.ThemeName = "MetroDark";
            this.txtStudName.UseSystemPasswordChar = false;
            this.txtStudName.WatermarkText = "Enter student\'s name";
            // 
            // cmbNumSelect
            // 
            this.cmbNumSelect.AllowDrop = true;
            this.cmbNumSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNumSelect.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbNumSelect.BackColor = System.Drawing.Color.Transparent;
            this.cmbNumSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbNumSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbNumSelect.CausesValidation = false;
            this.cmbNumSelect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbNumSelect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbNumSelect.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbNumSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNumSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbNumSelect.FormattingEnabled = true;
            this.cmbNumSelect.IsDerivedStyle = true;
            this.cmbNumSelect.ItemHeight = 20;
            this.cmbNumSelect.Location = new System.Drawing.Point(244, 122);
            this.cmbNumSelect.Name = "cmbNumSelect";
            this.cmbNumSelect.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbNumSelect.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbNumSelect.Size = new System.Drawing.Size(269, 26);
            this.cmbNumSelect.Style = MetroSet_UI.Enums.Style.Dark;
            this.cmbNumSelect.StyleManager = null;
            this.cmbNumSelect.TabIndex = 58;
            this.cmbNumSelect.ThemeAuthor = "Narwin";
            this.cmbNumSelect.ThemeName = "MetroDark";
            this.cmbNumSelect.SelectedValueChanged += new System.EventHandler(this.cmbNumSelect_SelectedValueChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelect.IsDerivedStyle = true;
            this.lblSelect.Location = new System.Drawing.Point(244, 96);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(269, 23);
            this.lblSelect.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblSelect.StyleManager = null;
            this.lblSelect.TabIndex = 57;
            this.lblSelect.Text = "Select a Student Number to Update:";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelect.ThemeAuthor = "Narwin";
            this.lblSelect.ThemeName = "MetroDark";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.IsDerivedStyle = true;
            this.lblName.Location = new System.Drawing.Point(115, 169);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblName.StyleManager = null;
            this.lblName.TabIndex = 60;
            this.lblName.Text = "Name:";
            this.lblName.ThemeAuthor = "Narwin";
            this.lblName.ThemeName = "MetroDark";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNum.IsDerivedStyle = true;
            this.lblNum.Location = new System.Drawing.Point(465, 169);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(122, 17);
            this.lblNum.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblNum.StyleManager = null;
            this.lblNum.TabIndex = 61;
            this.lblNum.Text = "Student Surname:";
            this.lblNum.ThemeAuthor = "Narwin";
            this.lblNum.ThemeName = "MetroDark";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDOB.IsDerivedStyle = true;
            this.lblDOB.Location = new System.Drawing.Point(115, 228);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(91, 17);
            this.lblDOB.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblDOB.StyleManager = null;
            this.lblDOB.TabIndex = 62;
            this.lblDOB.Text = "Date of Birth:";
            this.lblDOB.ThemeAuthor = "Narwin";
            this.lblDOB.ThemeName = "MetroDark";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGender.IsDerivedStyle = true;
            this.lblGender.Location = new System.Drawing.Point(465, 222);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblGender.StyleManager = null;
            this.lblGender.TabIndex = 63;
            this.lblGender.Text = "Gender:";
            this.lblGender.ThemeAuthor = "Narwin";
            this.lblGender.ThemeName = "MetroDark";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone.IsDerivedStyle = true;
            this.lblPhone.Location = new System.Drawing.Point(115, 280);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(107, 17);
            this.lblPhone.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblPhone.StyleManager = null;
            this.lblPhone.TabIndex = 64;
            this.lblPhone.Text = "Phone Number:";
            this.lblPhone.ThemeAuthor = "Narwin";
            this.lblPhone.ThemeName = "MetroDark";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress.IsDerivedStyle = true;
            this.lblAddress.Location = new System.Drawing.Point(465, 280);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblAddress.StyleManager = null;
            this.lblAddress.TabIndex = 65;
            this.lblAddress.Text = "Address:";
            this.lblAddress.ThemeAuthor = "Narwin";
            this.lblAddress.ThemeName = "MetroDark";
            // 
            // lblToAdd
            // 
            this.lblToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblToAdd.IsDerivedStyle = true;
            this.lblToAdd.Location = new System.Drawing.Point(115, 357);
            this.lblToAdd.Name = "lblToAdd";
            this.lblToAdd.Size = new System.Drawing.Size(217, 23);
            this.lblToAdd.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblToAdd.StyleManager = null;
            this.lblToAdd.TabIndex = 66;
            this.lblToAdd.Text = "Select Modules To Add:";
            this.lblToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToAdd.ThemeAuthor = "Narwin";
            this.lblToAdd.ThemeName = "MetroDark";
            // 
            // lbxToAdd
            // 
            this.lbxToAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbxToAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbxToAdd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbxToAdd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbxToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbxToAdd.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.lbxToAdd.HoveredItemColor = System.Drawing.Color.DimGray;
            this.lbxToAdd.IsDerivedStyle = true;
            this.lbxToAdd.ItemHeight = 30;
            this.lbxToAdd.Location = new System.Drawing.Point(115, 383);
            this.lbxToAdd.MultiSelect = false;
            this.lbxToAdd.Name = "lbxToAdd";
            this.lbxToAdd.SelectedIndex = -1;
            this.lbxToAdd.SelectedItem = null;
            this.lbxToAdd.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lbxToAdd.SelectedItemColor = System.Drawing.Color.White;
            this.lbxToAdd.SelectedText = null;
            this.lbxToAdd.SelectedValue = null;
            this.lbxToAdd.ShowBorder = false;
            this.lbxToAdd.ShowScrollBar = false;
            this.lbxToAdd.Size = new System.Drawing.Size(217, 212);
            this.lbxToAdd.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbxToAdd.StyleManager = null;
            this.lbxToAdd.TabIndex = 67;
            this.lbxToAdd.ThemeAuthor = "Narwin";
            this.lbxToAdd.ThemeName = "MetroDark";
            // 
            // lblAdded
            // 
            this.lblAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAdded.IsDerivedStyle = true;
            this.lblAdded.Location = new System.Drawing.Point(465, 357);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(217, 23);
            this.lblAdded.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblAdded.StyleManager = null;
            this.lblAdded.TabIndex = 68;
            this.lblAdded.Text = "Current Modules(Deselectable):";
            this.lblAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdded.ThemeAuthor = "Narwin";
            this.lblAdded.ThemeName = "MetroDark";
            // 
            // lbxCurrent
            // 
            this.lbxCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbxCurrent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbxCurrent.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbxCurrent.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbxCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbxCurrent.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.lbxCurrent.HoveredItemColor = System.Drawing.Color.DimGray;
            this.lbxCurrent.IsDerivedStyle = true;
            this.lbxCurrent.ItemHeight = 30;
            this.lbxCurrent.Location = new System.Drawing.Point(465, 383);
            this.lbxCurrent.MultiSelect = false;
            this.lbxCurrent.Name = "lbxCurrent";
            this.lbxCurrent.SelectedIndex = -1;
            this.lbxCurrent.SelectedItem = null;
            this.lbxCurrent.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lbxCurrent.SelectedItemColor = System.Drawing.Color.White;
            this.lbxCurrent.SelectedText = null;
            this.lbxCurrent.SelectedValue = null;
            this.lbxCurrent.ShowBorder = false;
            this.lbxCurrent.ShowScrollBar = false;
            this.lbxCurrent.Size = new System.Drawing.Size(217, 212);
            this.lbxCurrent.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbxCurrent.StyleManager = null;
            this.lbxCurrent.TabIndex = 69;
            this.lbxCurrent.ThemeAuthor = "Narwin";
            this.lbxCurrent.ThemeName = "MetroDark";
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUpdate.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.IsDerivedStyle = true;
            this.btnUpdate.Location = new System.Drawing.Point(512, 658);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUpdate.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnUpdate.NormalTextColor = System.Drawing.Color.White;
            this.btnUpdate.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnUpdate.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnUpdate.PressTextColor = System.Drawing.Color.White;
            this.btnUpdate.Size = new System.Drawing.Size(145, 53);
            this.btnUpdate.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnUpdate.StyleManager = null;
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.ThemeAuthor = "Narwin";
            this.btnUpdate.ThemeName = "MetroDark";
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.IsDerivedStyle = true;
            this.btnCancel.Location = new System.Drawing.Point(148, 658);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCancel.NormalTextColor = System.Drawing.Color.White;
            this.btnCancel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.PressTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(145, 53);
            this.btnCancel.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnCancel.StyleManager = null;
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeAuthor = "Narwin";
            this.btnCancel.ThemeName = "MetroDark";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 726);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbxCurrent);
            this.Controls.Add(this.lblAdded);
            this.Controls.Add(this.lbxToAdd);
            this.Controls.Add(this.lblToAdd);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbNumSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.DateStudDOB);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtStudPhone);
            this.Controls.Add(this.txtStudSurname);
            this.Controls.Add(this.txtStudName);
            this.Name = "UpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "UPDATE STUDENT DETAILS";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox DateStudDOB;
        private MetroSet_UI.Controls.MetroSetComboBox cmbGender;
        private MetroSet_UI.Controls.MetroSetTextBox txtAddress;
        private MetroSet_UI.Controls.MetroSetTextBox txtStudPhone;
        private MetroSet_UI.Controls.MetroSetTextBox txtStudSurname;
        private MetroSet_UI.Controls.MetroSetTextBox txtStudName;
        private MetroSet_UI.Controls.MetroSetComboBox cmbNumSelect;
        private MetroSet_UI.Controls.MetroSetLabel lblSelect;
        private MetroSet_UI.Controls.MetroSetLabel lblName;
        private MetroSet_UI.Controls.MetroSetLabel lblNum;
        private MetroSet_UI.Controls.MetroSetLabel lblDOB;
        private MetroSet_UI.Controls.MetroSetLabel lblGender;
        private MetroSet_UI.Controls.MetroSetLabel lblPhone;
        private MetroSet_UI.Controls.MetroSetLabel lblAddress;
        private MetroSet_UI.Controls.MetroSetLabel lblToAdd;
        private MetroSet_UI.Controls.MetroSetListBox lbxToAdd;
        private MetroSet_UI.Controls.MetroSetLabel lblAdded;
        private MetroSet_UI.Controls.MetroSetListBox lbxCurrent;
        private MetroSet_UI.Controls.MetroSetButton btnUpdate;
        private MetroSet_UI.Controls.MetroSetButton btnCancel;
    }
}