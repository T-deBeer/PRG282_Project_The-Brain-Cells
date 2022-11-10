namespace PRG282_Project_The_Brain_Cells
{
    partial class LogFileViewer
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
            this.mrtbLogFile = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
            this.btnBack = new MetroSet_UI.Controls.MetroSetButton();
            this.btnSend = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // mrtbLogFile
            // 
            this.mrtbLogFile.AutoWordSelection = false;
            this.mrtbLogFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mrtbLogFile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mrtbLogFile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mrtbLogFile.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mrtbLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mrtbLogFile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.mrtbLogFile.IsDerivedStyle = true;
            this.mrtbLogFile.Lines = null;
            this.mrtbLogFile.Location = new System.Drawing.Point(15, 99);
            this.mrtbLogFile.MaxLength = 32767;
            this.mrtbLogFile.Name = "mrtbLogFile";
            this.mrtbLogFile.ReadOnly = false;
            this.mrtbLogFile.Size = new System.Drawing.Size(770, 345);
            this.mrtbLogFile.Style = MetroSet_UI.Enums.Style.Dark;
            this.mrtbLogFile.StyleManager = null;
            this.mrtbLogFile.TabIndex = 0;
            this.mrtbLogFile.ThemeAuthor = "Narwin";
            this.mrtbLogFile.ThemeName = "MetroDark";
            this.mrtbLogFile.WordWrap = true;
            // 
            // btnSave
            // 
            this.btnSave.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.White;
            this.btnSave.IsDerivedStyle = true;
            this.btnSave.Location = new System.Drawing.Point(428, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSave.NormalTextColor = System.Drawing.Color.White;
            this.btnSave.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSave.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSave.PressTextColor = System.Drawing.Color.White;
            this.btnSave.Size = new System.Drawing.Size(167, 53);
            this.btnSave.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnSave.StyleManager = null;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save File";
            this.btnSave.ThemeAuthor = "Narwin";
            this.btnSave.ThemeName = "MetroDark";
            // 
            // btnBack
            // 
            this.btnBack.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBack.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.IsDerivedStyle = true;
            this.btnBack.Location = new System.Drawing.Point(15, 496);
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnBack.NormalTextColor = System.Drawing.Color.White;
            this.btnBack.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBack.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBack.PressTextColor = System.Drawing.Color.White;
            this.btnBack.Size = new System.Drawing.Size(167, 53);
            this.btnBack.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnBack.StyleManager = null;
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.ThemeAuthor = "Narwin";
            this.btnBack.ThemeName = "MetroDark";
            this.btnBack.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSend.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSend.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSend.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSend.HoverTextColor = System.Drawing.Color.White;
            this.btnSend.IsDerivedStyle = true;
            this.btnSend.Location = new System.Drawing.Point(618, 496);
            this.btnSend.Name = "btnSend";
            this.btnSend.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSend.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSend.NormalTextColor = System.Drawing.Color.White;
            this.btnSend.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSend.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSend.PressTextColor = System.Drawing.Color.White;
            this.btnSend.Size = new System.Drawing.Size(167, 53);
            this.btnSend.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnSend.StyleManager = null;
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send Log via Email";
            this.btnSend.ThemeAuthor = "Narwin";
            this.btnSend.ThemeName = "MetroDark";
            // 
            // LogFileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mrtbLogFile);
            this.Name = "LogFileViewer";
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "LOG FILE VIEWER";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetRichTextBox mrtbLogFile;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Controls.MetroSetButton btnBack;
        private MetroSet_UI.Controls.MetroSetButton btnSend;
    }
}