namespace PRG282_Project_The_Brain_Cells
{
    partial class Dashboard
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
            this.lblSelect = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbTableSelect = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnExit = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAdd = new MetroSet_UI.Controls.MetroSetButton();
            this.rtbEdit = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnRemove = new MetroSet_UI.Controls.MetroSetButton();
            this.dgvDataBaseView = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new MetroSet_UI.Controls.MetroSetButton();
            this.btnNext = new MetroSet_UI.Controls.MetroSetButton();
            this.btnUpdate = new MetroSet_UI.Controls.MetroSetButton();
            this.lblSearch = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnSearch = new MetroSet_UI.Controls.MetroSetButton();
            this.txtSearch = new MetroSet_UI.Controls.MetroSetTextBox();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelect.IsDerivedStyle = true;
            this.lblSelect.Location = new System.Drawing.Point(130, 83);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(213, 23);
            this.lblSelect.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblSelect.StyleManager = null;
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select a Table to View:";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelect.ThemeAuthor = "Narwin";
            this.lblSelect.ThemeName = "MetroDark";
            // 
            // cmbTableSelect
            // 
            this.cmbTableSelect.AllowDrop = true;
            this.cmbTableSelect.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbTableSelect.BackColor = System.Drawing.Color.Transparent;
            this.cmbTableSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbTableSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbTableSelect.CausesValidation = false;
            this.cmbTableSelect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbTableSelect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbTableSelect.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbTableSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTableSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbTableSelect.FormattingEnabled = true;
            this.cmbTableSelect.IsDerivedStyle = true;
            this.cmbTableSelect.ItemHeight = 20;
            this.cmbTableSelect.Location = new System.Drawing.Point(130, 109);
            this.cmbTableSelect.Name = "cmbTableSelect";
            this.cmbTableSelect.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbTableSelect.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbTableSelect.Size = new System.Drawing.Size(213, 26);
            this.cmbTableSelect.Style = MetroSet_UI.Enums.Style.Dark;
            this.cmbTableSelect.StyleManager = null;
            this.cmbTableSelect.TabIndex = 2;
            this.cmbTableSelect.ThemeAuthor = "Narwin";
            this.cmbTableSelect.ThemeName = "MetroDark";
            this.cmbTableSelect.SelectedIndexChanged += new System.EventHandler(this.cmbTableSelect_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExit.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.HoverTextColor = System.Drawing.Color.White;
            this.btnExit.IsDerivedStyle = true;
            this.btnExit.Location = new System.Drawing.Point(15, 602);
            this.btnExit.Name = "btnExit";
            this.btnExit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnExit.NormalTextColor = System.Drawing.Color.White;
            this.btnExit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExit.PressTextColor = System.Drawing.Color.White;
            this.btnExit.Size = new System.Drawing.Size(145, 53);
            this.btnExit.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnExit.StyleManager = null;
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.ThemeAuthor = "Narwin";
            this.btnExit.ThemeName = "MetroDark";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(208, 541);
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
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.ThemeAuthor = "Narwin";
            this.btnAdd.ThemeName = "MetroDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtbEdit
            // 
            this.rtbEdit.AutoWordSelection = false;
            this.rtbEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.rtbEdit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rtbEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rtbEdit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rtbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbEdit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rtbEdit.IsDerivedStyle = true;
            this.rtbEdit.Lines = null;
            this.rtbEdit.Location = new System.Drawing.Point(934, 148);
            this.rtbEdit.MaxLength = 32767;
            this.rtbEdit.Name = "rtbEdit";
            this.rtbEdit.ReadOnly = false;
            this.rtbEdit.Size = new System.Drawing.Size(331, 345);
            this.rtbEdit.Style = MetroSet_UI.Enums.Style.Dark;
            this.rtbEdit.StyleManager = null;
            this.rtbEdit.TabIndex = 5;
            this.rtbEdit.ThemeAuthor = "Narwin";
            this.rtbEdit.ThemeName = "MetroDark";
            this.rtbEdit.WordWrap = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(1103, 148);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(162, 170);
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemove.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemove.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnRemove.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnRemove.HoverTextColor = System.Drawing.Color.White;
            this.btnRemove.IsDerivedStyle = true;
            this.btnRemove.Location = new System.Drawing.Point(392, 541);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemove.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRemove.NormalTextColor = System.Drawing.Color.White;
            this.btnRemove.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnRemove.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnRemove.PressTextColor = System.Drawing.Color.White;
            this.btnRemove.Size = new System.Drawing.Size(145, 53);
            this.btnRemove.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnRemove.StyleManager = null;
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.ThemeAuthor = "Narwin";
            this.btnRemove.ThemeName = "MetroDark";
            // 
            // dgvDataBaseView
            // 
            this.dgvDataBaseView.AllowUserToAddRows = false;
            this.dgvDataBaseView.AllowUserToDeleteRows = false;
            this.dgvDataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataBaseView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataBaseView.Location = new System.Drawing.Point(15, 148);
            this.dgvDataBaseView.MultiSelect = false;
            this.dgvDataBaseView.Name = "dgvDataBaseView";
            this.dgvDataBaseView.ReadOnly = true;
            this.dgvDataBaseView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataBaseView.Size = new System.Drawing.Size(913, 344);
            this.dgvDataBaseView.TabIndex = 12;
            this.dgvDataBaseView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDataBaseView_CellFormatting);
            this.dgvDataBaseView.SelectionChanged += new System.EventHandler(this.dgvDataBaseView_SelectionChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrevious.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrevious.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrevious.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPrevious.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPrevious.HoverTextColor = System.Drawing.Color.White;
            this.btnPrevious.IsDerivedStyle = true;
            this.btnPrevious.Location = new System.Drawing.Point(15, 498);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrevious.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPrevious.NormalTextColor = System.Drawing.Color.White;
            this.btnPrevious.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPrevious.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPrevious.PressTextColor = System.Drawing.Color.White;
            this.btnPrevious.Size = new System.Drawing.Size(133, 26);
            this.btnPrevious.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnPrevious.StyleManager = null;
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.Text = "<< Previous ";
            this.btnPrevious.ThemeAuthor = "Narwin";
            this.btnPrevious.ThemeName = "MetroDark";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNext.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnNext.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnNext.HoverTextColor = System.Drawing.Color.White;
            this.btnNext.IsDerivedStyle = true;
            this.btnNext.Location = new System.Drawing.Point(796, 498);
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNext.NormalTextColor = System.Drawing.Color.White;
            this.btnNext.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNext.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNext.PressTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(133, 26);
            this.btnNext.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnNext.StyleManager = null;
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next >>";
            this.btnNext.ThemeAuthor = "Narwin";
            this.btnNext.ThemeName = "MetroDark";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(577, 541);
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
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.ThemeAuthor = "Narwin";
            this.btnUpdate.ThemeName = "MetroDark";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearch.IsDerivedStyle = true;
            this.lblSearch.Location = new System.Drawing.Point(447, 83);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(221, 23);
            this.lblSearch.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblSearch.StyleManager = null;
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearch.ThemeAuthor = "Narwin";
            this.lblSearch.ThemeName = "MetroDark";
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.White;
            this.btnSearch.IsDerivedStyle = true;
            this.btnSearch.Location = new System.Drawing.Point(674, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnSearch.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.NormalTextColor = System.Drawing.Color.White;
            this.btnSearch.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSearch.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSearch.PressTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnSearch.StyleManager = null;
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeAuthor = "Narwin";
            this.btnSearch.ThemeName = "MetroDark";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource = null;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtSearch.Image = null;
            this.txtSearch.IsDerivedStyle = true;
            this.txtSearch.Lines = null;
            this.txtSearch.Location = new System.Drawing.Point(447, 109);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(221, 26);
            this.txtSearch.Style = MetroSet_UI.Enums.Style.Dark;
            this.txtSearch.StyleManager = null;
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.ThemeAuthor = "Narwin";
            this.txtSearch.ThemeName = "MetroDark";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WatermarkText = "";
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.CausesValidation = false;
            this.cmbSortBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Location = new System.Drawing.Point(305, 496);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(337, 28);
            this.cmbSortBy.TabIndex = 21;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1280, 687);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvDataBaseView);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.rtbEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbTableSelect);
            this.Controls.Add(this.lblSelect);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "DASHBOARD";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBaseView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetLabel lblSelect;
        private MetroSet_UI.Controls.MetroSetComboBox cmbTableSelect;
        private MetroSet_UI.Controls.MetroSetButton btnExit;
        private MetroSet_UI.Controls.MetroSetButton btnAdd;
        private MetroSet_UI.Controls.MetroSetRichTextBox rtbEdit;
        private System.Windows.Forms.PictureBox pbImage;
        private MetroSet_UI.Controls.MetroSetButton btnRemove;
        private System.Windows.Forms.DataGridView dgvDataBaseView;
        private MetroSet_UI.Controls.MetroSetButton btnPrevious;
        private MetroSet_UI.Controls.MetroSetButton btnNext;
        private MetroSet_UI.Controls.MetroSetButton btnUpdate;
        private MetroSet_UI.Controls.MetroSetLabel lblSearch;
        private MetroSet_UI.Controls.MetroSetButton btnSearch;
        private MetroSet_UI.Controls.MetroSetTextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSortBy;
    }
}