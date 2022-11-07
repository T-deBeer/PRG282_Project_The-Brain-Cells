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
            this.dgvDataBase = new System.Windows.Forms.DataGridView();
            this.lblSelect = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbTableSelect = new MetroSet_UI.Controls.MetroSetComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataBase
            // 
            this.dgvDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBase.Location = new System.Drawing.Point(15, 96);
            this.dgvDataBase.Name = "dgvDataBase";
            this.dgvDataBase.Size = new System.Drawing.Size(897, 345);
            this.dgvDataBase.TabIndex = 0;
            // 
            // lblSelect
            // 
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelect.IsDerivedStyle = true;
            this.lblSelect.Location = new System.Drawing.Point(1027, 96);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(160, 23);
            this.lblSelect.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblSelect.StyleManager = null;
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select a Table to View:";
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
            this.cmbTableSelect.Location = new System.Drawing.Point(1000, 122);
            this.cmbTableSelect.Name = "cmbTableSelect";
            this.cmbTableSelect.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbTableSelect.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbTableSelect.Size = new System.Drawing.Size(213, 26);
            this.cmbTableSelect.Style = MetroSet_UI.Enums.Style.Dark;
            this.cmbTableSelect.StyleManager = null;
            this.cmbTableSelect.TabIndex = 2;
            this.cmbTableSelect.ThemeAuthor = "Narwin";
            this.cmbTableSelect.ThemeName = "MetroDark";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.cmbTableSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.dgvDataBase);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Dashboard";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataBase;
        private MetroSet_UI.Controls.MetroSetLabel lblSelect;
        private MetroSet_UI.Controls.MetroSetComboBox cmbTableSelect;
    }
}