namespace DSIS
{
    partial class Classroom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDailyAttendance = new Guna.UI.WinForms.GunaGroupBox();
            this.lbClsrmAttendance = new System.Windows.Forms.ListBox();
            this.gbCActivityList = new Guna.UI.WinForms.GunaGroupBox();
            this.lbClsrmActivities = new System.Windows.Forms.ListBox();
            this.gbDailyAttendance.SuspendLayout();
            this.gbCActivityList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDailyAttendance
            // 
            this.gbDailyAttendance.BackColor = System.Drawing.Color.Transparent;
            this.gbDailyAttendance.BaseColor = System.Drawing.Color.White;
            this.gbDailyAttendance.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbDailyAttendance.Controls.Add(this.lbClsrmAttendance);
            this.gbDailyAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDailyAttendance.ForeColor = System.Drawing.Color.White;
            this.gbDailyAttendance.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbDailyAttendance.Location = new System.Drawing.Point(25, 25);
            this.gbDailyAttendance.Name = "gbDailyAttendance";
            this.gbDailyAttendance.Size = new System.Drawing.Size(620, 620);
            this.gbDailyAttendance.TabIndex = 0;
            this.gbDailyAttendance.Text = "Dialy Attendance";
            this.gbDailyAttendance.TextLocation = new System.Drawing.Point(20, 2);
            // 
            // lbClsrmAttendance
            // 
            this.lbClsrmAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbClsrmAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbClsrmAttendance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClsrmAttendance.FormattingEnabled = true;
            this.lbClsrmAttendance.ItemHeight = 20;
            this.lbClsrmAttendance.Location = new System.Drawing.Point(0, 40);
            this.lbClsrmAttendance.Name = "lbClsrmAttendance";
            this.lbClsrmAttendance.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbClsrmAttendance.Size = new System.Drawing.Size(620, 580);
            this.lbClsrmAttendance.TabIndex = 0;
            // 
            // gbCActivityList
            // 
            this.gbCActivityList.BackColor = System.Drawing.Color.Transparent;
            this.gbCActivityList.BaseColor = System.Drawing.Color.White;
            this.gbCActivityList.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbCActivityList.Controls.Add(this.lbClsrmActivities);
            this.gbCActivityList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCActivityList.ForeColor = System.Drawing.Color.White;
            this.gbCActivityList.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbCActivityList.Location = new System.Drawing.Point(651, 25);
            this.gbCActivityList.Name = "gbCActivityList";
            this.gbCActivityList.Size = new System.Drawing.Size(480, 300);
            this.gbCActivityList.TabIndex = 0;
            this.gbCActivityList.Text = "Classroom Activities";
            this.gbCActivityList.TextLocation = new System.Drawing.Point(20, 2);
            // 
            // lbClsrmActivities
            // 
            this.lbClsrmActivities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbClsrmActivities.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbClsrmActivities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClsrmActivities.FormattingEnabled = true;
            this.lbClsrmActivities.ItemHeight = 20;
            this.lbClsrmActivities.Location = new System.Drawing.Point(0, 40);
            this.lbClsrmActivities.Name = "lbClsrmActivities";
            this.lbClsrmActivities.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbClsrmActivities.Size = new System.Drawing.Size(480, 260);
            this.lbClsrmActivities.TabIndex = 0;
            // 
            // Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbCActivityList);
            this.Controls.Add(this.gbDailyAttendance);
            this.Name = "Classroom";
            this.Size = new System.Drawing.Size(1150, 665);
            this.gbDailyAttendance.ResumeLayout(false);
            this.gbCActivityList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gbDailyAttendance;
        private Guna.UI.WinForms.GunaGroupBox gbCActivityList;
        public System.Windows.Forms.ListBox lbClsrmAttendance;
        public System.Windows.Forms.ListBox lbClsrmActivities;
    }
}
