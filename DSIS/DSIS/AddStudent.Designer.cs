namespace DSIS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tbPassword = new Guna.UI.WinForms.GunaTextBox();
            this.tbID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.tbRePassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(320, 275);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(82, 23);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Password:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(320, 237);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(82, 23);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "School ID: ";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            this.tbPassword.BaseColor = System.Drawing.Color.White;
            this.tbPassword.BorderColor = System.Drawing.Color.Silver;
            this.tbPassword.BorderSize = 1;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.tbPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.Location = new System.Drawing.Point(428, 271);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(338, 32);
            this.tbPassword.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.BaseColor = System.Drawing.Color.White;
            this.tbID.BorderColor = System.Drawing.Color.Silver;
            this.tbID.BorderSize = 1;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.FocusedBaseColor = System.Drawing.Color.White;
            this.tbID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbID.Location = new System.Drawing.Point(428, 233);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.Size = new System.Drawing.Size(338, 32);
            this.tbID.TabIndex = 1;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(324, 440);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(442, 42);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "Add ";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // tbRePassword
            // 
            this.tbRePassword.BaseColor = System.Drawing.Color.White;
            this.tbRePassword.BorderColor = System.Drawing.Color.Silver;
            this.tbRePassword.BorderSize = 1;
            this.tbRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRePassword.FocusedBaseColor = System.Drawing.Color.White;
            this.tbRePassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbRePassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbRePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbRePassword.Location = new System.Drawing.Point(428, 309);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.PasswordChar = '●';
            this.tbRePassword.Size = new System.Drawing.Size(338, 32);
            this.tbRePassword.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(320, 313);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 23);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Retype pass:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbID);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(1150, 665);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox tbPassword;
        private Guna.UI.WinForms.GunaTextBox tbID;
        private Guna.UI.WinForms.GunaTextBox tbRePassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
