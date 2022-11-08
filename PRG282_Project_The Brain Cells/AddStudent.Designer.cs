namespace PRG282_Project_The_Brain_Cells
{
    partial class AddStudent
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
            this.txtStdNum = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnAdd = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCancel = new MetroSet_UI.Controls.MetroSetButton();
            this.btnWrite = new MetroSet_UI.Controls.MetroSetButton();
            this.lbxToAdd = new MetroSet_UI.Controls.MetroSetListBox();
            this.txtStudName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtStudSurname = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtStudPhone = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtAddress = new MetroSet_UI.Controls.MetroSetTextBox();
            this.cmbGender = new MetroSet_UI.Controls.MetroSetComboBox();
            this.txtDOB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtStdNum
            // 
            this.txtStdNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStdNum.AutoCompleteCustomSource = null;
            this.txtStdNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStdNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStdNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtStdNum.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtStdNum.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStdNum.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStdNum.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtStdNum.Image = null;
            this.txtStdNum.IsDerivedStyle = true;
            this.txtStdNum.Lines = null;
            this.txtStdNum.Location = new System.Drawing.Point(40, 102);
            this.txtStdNum.MaxLength = 32767;
            this.txtStdNum.Multiline = false;
            this.txtStdNum.Name = "txtStdNum";
            this.txtStdNum.ReadOnly = false;
            this.txtStdNum.Size = new System.Drawing.Size(217, 26);
            this.txtStdNum.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtStdNum.StyleManager = null;
            this.txtStdNum.TabIndex = 44;
            this.txtStdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStdNum.ThemeAuthor = "Narwin";
            this.txtStdNum.ThemeName = "MetroDark";
            this.txtStdNum.UseSystemPasswordChar = false;
            this.txtStdNum.WatermarkText = "Enter student\'s Student Number";
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnAdd.IsDerivedStyle = true;
            this.btnAdd.Location = new System.Drawing.Point(363, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdd.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAdd.NormalTextColor = System.Drawing.Color.White;
            this.btnAdd.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAdd.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAdd.PressTextColor = System.Drawing.Color.White;
            this.btnAdd.Size = new System.Drawing.Size(145, 53);
            this.btnAdd.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnAdd.StyleManager = null;
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.ThemeAuthor = "Narwin";
            this.btnAdd.ThemeName = "MetroDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(40, 364);
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
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeAuthor = "Narwin";
            this.btnCancel.ThemeName = "MetroDark";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnWrite.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnWrite.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWrite.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnWrite.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnWrite.HoverTextColor = System.Drawing.Color.White;
            this.btnWrite.IsDerivedStyle = true;
            this.btnWrite.Location = new System.Drawing.Point(568, 364);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnWrite.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnWrite.NormalTextColor = System.Drawing.Color.White;
            this.btnWrite.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnWrite.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnWrite.PressTextColor = System.Drawing.Color.White;
            this.btnWrite.Size = new System.Drawing.Size(145, 53);
            this.btnWrite.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnWrite.StyleManager = null;
            this.btnWrite.TabIndex = 53;
            this.btnWrite.Text = "Write to Database";
            this.btnWrite.ThemeAuthor = "Narwin";
            this.btnWrite.ThemeName = "MetroDark";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
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
            this.lbxToAdd.Location = new System.Drawing.Point(363, 102);
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
            this.lbxToAdd.Size = new System.Drawing.Size(350, 212);
            this.lbxToAdd.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbxToAdd.StyleManager = null;
            this.lbxToAdd.TabIndex = 54;
            this.lbxToAdd.ThemeAuthor = "Narwin";
            this.lbxToAdd.ThemeName = "MetroDark";
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
            this.txtStudName.Location = new System.Drawing.Point(40, 134);
            this.txtStudName.MaxLength = 32767;
            this.txtStudName.Multiline = false;
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.ReadOnly = false;
            this.txtStudName.Size = new System.Drawing.Size(217, 26);
            this.txtStudName.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtStudName.StyleManager = null;
            this.txtStudName.TabIndex = 45;
            this.txtStudName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudName.ThemeAuthor = "Narwin";
            this.txtStudName.ThemeName = "MetroDark";
            this.txtStudName.UseSystemPasswordChar = false;
            this.txtStudName.WatermarkText = "Enter student\'s name";
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
            this.txtStudSurname.Location = new System.Drawing.Point(40, 166);
            this.txtStudSurname.MaxLength = 32767;
            this.txtStudSurname.Multiline = false;
            this.txtStudSurname.Name = "txtStudSurname";
            this.txtStudSurname.ReadOnly = false;
            this.txtStudSurname.Size = new System.Drawing.Size(217, 26);
            this.txtStudSurname.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtStudSurname.StyleManager = null;
            this.txtStudSurname.TabIndex = 46;
            this.txtStudSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudSurname.ThemeAuthor = "Narwin";
            this.txtStudSurname.ThemeName = "MetroDark";
            this.txtStudSurname.UseSystemPasswordChar = false;
            this.txtStudSurname.WatermarkText = "Enter student\'s surname";
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
            this.txtStudPhone.Location = new System.Drawing.Point(40, 256);
            this.txtStudPhone.MaxLength = 10;
            this.txtStudPhone.Multiline = false;
            this.txtStudPhone.Name = "txtStudPhone";
            this.txtStudPhone.ReadOnly = false;
            this.txtStudPhone.Size = new System.Drawing.Size(217, 26);
            this.txtStudPhone.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtStudPhone.StyleManager = null;
            this.txtStudPhone.TabIndex = 47;
            this.txtStudPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudPhone.ThemeAuthor = "Narwin";
            this.txtStudPhone.ThemeName = "MetroDark";
            this.txtStudPhone.UseSystemPasswordChar = false;
            this.txtStudPhone.WatermarkText = "Enter student\'s phone number";
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
            this.txtAddress.Location = new System.Drawing.Point(40, 288);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = false;
            this.txtAddress.Size = new System.Drawing.Size(217, 26);
            this.txtAddress.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtAddress.StyleManager = null;
            this.txtAddress.TabIndex = 48;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.ThemeAuthor = "Narwin";
            this.txtAddress.ThemeName = "MetroDark";
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.WatermarkText = "Enter student\'s Address";
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
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(40, 224);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbGender.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbGender.Size = new System.Drawing.Size(217, 26);
            this.cmbGender.Style = MetroSet_UI.Enums.Style.Custom;
            this.cmbGender.StyleManager = null;
            this.cmbGender.TabIndex = 49;
            this.cmbGender.ThemeAuthor = "Narwin";
            this.cmbGender.ThemeName = "MetroDark";
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDOB.Location = new System.Drawing.Point(40, 198);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(217, 20);
            this.txtDOB.TabIndex = 50;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxToAdd);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtStudPhone);
            this.Controls.Add(this.txtStudSurname);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.txtStdNum);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "ADD NEW STUDENT DETAILS";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTextBox txtStdNum;
        private MetroSet_UI.Controls.MetroSetButton btnAdd;
        private MetroSet_UI.Controls.MetroSetButton btnCancel;
        private MetroSet_UI.Controls.MetroSetButton btnWrite;
        private MetroSet_UI.Controls.MetroSetListBox lbxToAdd;
        private MetroSet_UI.Controls.MetroSetTextBox txtStudName;
        private MetroSet_UI.Controls.MetroSetTextBox txtStudSurname;
        private MetroSet_UI.Controls.MetroSetTextBox txtStudPhone;
        private MetroSet_UI.Controls.MetroSetTextBox txtAddress;
        private MetroSet_UI.Controls.MetroSetComboBox cmbGender;
        private System.Windows.Forms.MaskedTextBox txtDOB;
    }
}