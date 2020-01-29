namespace DSIS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel = new Guna.UI.WinForms.GunaPanel();
            this.pageLabel = new Guna.UI.WinForms.GunaLabel();
            this.controlMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.controlClose = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lblLogout = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.mainPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.lblAddStudent = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnSchool = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClassroom = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnScores = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.lblAddStudent);
            this.topPanel.Controls.Add(this.gunaPictureBox1);
            this.topPanel.Controls.Add(this.pageLabel);
            this.topPanel.Controls.Add(this.controlMinimize);
            this.topPanel.Controls.Add(this.controlClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1350, 35);
            this.topPanel.TabIndex = 0;
            // 
            // pageLabel
            // 
            this.pageLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pageLabel.ForeColor = System.Drawing.Color.White;
            this.pageLabel.Location = new System.Drawing.Point(200, 3);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(1045, 32);
            this.pageLabel.TabIndex = 2;
            this.pageLabel.Text = "Page Label";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlMinimize
            // 
            this.controlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlMinimize.AnimationHoverSpeed = 0.07F;
            this.controlMinimize.AnimationSpeed = 0.03F;
            this.controlMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.controlMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlMinimize.IconColor = System.Drawing.Color.White;
            this.controlMinimize.IconSize = 15F;
            this.controlMinimize.Location = new System.Drawing.Point(1251, 3);
            this.controlMinimize.Name = "controlMinimize";
            this.controlMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.controlMinimize.OnHoverIconColor = System.Drawing.Color.White;
            this.controlMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.controlMinimize.Size = new System.Drawing.Size(45, 29);
            this.controlMinimize.TabIndex = 1;
            // 
            // controlClose
            // 
            this.controlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlClose.AnimationHoverSpeed = 0.07F;
            this.controlClose.AnimationSpeed = 0.03F;
            this.controlClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlClose.IconColor = System.Drawing.Color.White;
            this.controlClose.IconSize = 15F;
            this.controlClose.Location = new System.Drawing.Point(1302, 3);
            this.controlClose.Name = "controlClose";
            this.controlClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.controlClose.OnHoverIconColor = System.Drawing.Color.White;
            this.controlClose.OnPressedColor = System.Drawing.Color.Black;
            this.controlClose.Size = new System.Drawing.Size(45, 29);
            this.controlClose.TabIndex = 1;
            this.controlClose.Click += new System.EventHandler(this.ControlClose_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.topPanel;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.sidePanel.Controls.Add(this.lblLogout);
            this.sidePanel.Controls.Add(this.lblID);
            this.sidePanel.Controls.Add(this.gunaLabel1);
            this.sidePanel.Controls.Add(this.btnSchool);
            this.sidePanel.Controls.Add(this.btnClassroom);
            this.sidePanel.Controls.Add(this.btnScores);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 35);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 665);
            this.sidePanel.TabIndex = 1;
            // 
            // lblLogout
            // 
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLogout.LinkColor = System.Drawing.Color.IndianRed;
            this.lblLogout.Location = new System.Drawing.Point(0, 607);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(200, 58);
            this.lblLogout.TabIndex = 2;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLogout_LinkClicked);
            // 
            // lblID
            // 
            this.lblID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblID.Location = new System.Drawing.Point(0, 96);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(200, 23);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "School ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(200, 96);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "D S I S";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1150, 665);
            this.mainPanel.TabIndex = 2;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.pageLabel;
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddStudent.LinkColor = System.Drawing.Color.White;
            this.lblAddStudent.Location = new System.Drawing.Point(56, 9);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(92, 20);
            this.lblAddStudent.TabIndex = 5;
            this.lblAddStudent.TabStop = true;
            this.lblAddStudent.Text = "Add Student";
            this.lblAddStudent.Visible = false;
            this.lblAddStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblAddStudent_LinkClicked);
            // 
            // btnSchool
            // 
            this.btnSchool.AnimationHoverSpeed = 0.07F;
            this.btnSchool.AnimationSpeed = 0.03F;
            this.btnSchool.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSchool.BorderColor = System.Drawing.Color.Black;
            this.btnSchool.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSchool.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSchool.CheckedForeColor = System.Drawing.Color.White;
            this.btnSchool.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSchool.CheckedImage")));
            this.btnSchool.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchool.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSchool.FocusedColor = System.Drawing.Color.Empty;
            this.btnSchool.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSchool.ForeColor = System.Drawing.Color.White;
            this.btnSchool.Image = global::DSIS.Properties.Resources.school;
            this.btnSchool.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSchool.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSchool.Location = new System.Drawing.Point(0, 278);
            this.btnSchool.Name = "btnSchool";
            this.btnSchool.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSchool.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSchool.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSchool.OnHoverImage = null;
            this.btnSchool.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSchool.OnPressedColor = System.Drawing.Color.Black;
            this.btnSchool.Size = new System.Drawing.Size(200, 50);
            this.btnSchool.TabIndex = 2;
            this.btnSchool.Text = "School";
            this.btnSchool.Click += new System.EventHandler(this.BtnSchool_Click);
            // 
            // btnClassroom
            // 
            this.btnClassroom.AnimationHoverSpeed = 0.07F;
            this.btnClassroom.AnimationSpeed = 0.03F;
            this.btnClassroom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnClassroom.BorderColor = System.Drawing.Color.Black;
            this.btnClassroom.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnClassroom.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClassroom.CheckedForeColor = System.Drawing.Color.White;
            this.btnClassroom.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnClassroom.CheckedImage")));
            this.btnClassroom.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassroom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClassroom.FocusedColor = System.Drawing.Color.Empty;
            this.btnClassroom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClassroom.ForeColor = System.Drawing.Color.White;
            this.btnClassroom.Image = global::DSIS.Properties.Resources.classroom;
            this.btnClassroom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClassroom.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClassroom.Location = new System.Drawing.Point(0, 222);
            this.btnClassroom.Name = "btnClassroom";
            this.btnClassroom.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClassroom.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClassroom.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClassroom.OnHoverImage = null;
            this.btnClassroom.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClassroom.OnPressedColor = System.Drawing.Color.Black;
            this.btnClassroom.Size = new System.Drawing.Size(200, 50);
            this.btnClassroom.TabIndex = 2;
            this.btnClassroom.Text = "Classroom";
            this.btnClassroom.Click += new System.EventHandler(this.BtnClassroom_Click);
            // 
            // btnScores
            // 
            this.btnScores.AnimationHoverSpeed = 0.07F;
            this.btnScores.AnimationSpeed = 0.03F;
            this.btnScores.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnScores.BorderColor = System.Drawing.Color.Black;
            this.btnScores.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnScores.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnScores.CheckedForeColor = System.Drawing.Color.White;
            this.btnScores.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnScores.CheckedImage")));
            this.btnScores.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnScores.FocusedColor = System.Drawing.Color.Empty;
            this.btnScores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnScores.ForeColor = System.Drawing.Color.White;
            this.btnScores.Image = global::DSIS.Properties.Resources.score1;
            this.btnScores.ImageSize = new System.Drawing.Size(40, 40);
            this.btnScores.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnScores.Location = new System.Drawing.Point(0, 166);
            this.btnScores.Name = "btnScores";
            this.btnScores.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnScores.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnScores.OnHoverForeColor = System.Drawing.Color.White;
            this.btnScores.OnHoverImage = null;
            this.btnScores.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnScores.OnPressedColor = System.Drawing.Color.Black;
            this.btnScores.Size = new System.Drawing.Size(200, 50);
            this.btnScores.TabIndex = 2;
            this.btnScores.Text = "Scores";
            this.btnScores.Click += new System.EventHandler(this.GunaAdvenceButton1_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DSIS.Properties.Resources.desktop;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(26, 26);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSIS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel topPanel;
        private Guna.UI.WinForms.GunaControlBox controlMinimize;
        private Guna.UI.WinForms.GunaControlBox controlClose;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaLinkLabel lblLogout;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnSchool;
        private Guna.UI.WinForms.GunaAdvenceButton btnClassroom;
        private Guna.UI.WinForms.GunaAdvenceButton btnScores;
        private System.Windows.Forms.Panel sidePanel;
        private Guna.UI.WinForms.GunaPanel mainPanel;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel pageLabel;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaLinkLabel lblAddStudent;
    }
}