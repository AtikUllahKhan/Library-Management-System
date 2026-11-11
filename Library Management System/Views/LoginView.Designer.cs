namespace Library_Management_System.Views
{
    partial class Loginview
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.useridtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.showcheckbox = new System.Windows.Forms.CheckBox();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(27, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "  User Id:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "   Library Management System";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = " Password:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // useridtextbox
            // 
            this.useridtextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridtextbox.Location = new System.Drawing.Point(179, 130);
            this.useridtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useridtextbox.Multiline = true;
            this.useridtextbox.Name = "useridtextbox";
            this.useridtextbox.Size = new System.Drawing.Size(271, 36);
            this.useridtextbox.TabIndex = 4;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextbox.Location = new System.Drawing.Point(179, 199);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtextbox.Multiline = true;
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(271, 36);
            this.passwordtextbox.TabIndex = 5;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.DarkGreen;
            this.loginbutton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(179, 267);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(119, 43);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbutton.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(331, 267);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(117, 43);
            this.exitbutton.TabIndex = 8;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // showcheckbox
            // 
            this.showcheckbox.AutoSize = true;
            this.showcheckbox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcheckbox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.showcheckbox.Location = new System.Drawing.Point(476, 202);
            this.showcheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showcheckbox.Name = "showcheckbox";
            this.showcheckbox.Size = new System.Drawing.Size(83, 30);
            this.showcheckbox.TabIndex = 9;
            this.showcheckbox.Text = "Show";
            this.showcheckbox.UseVisualStyleBackColor = true;
            this.showcheckbox.CheckedChanged += new System.EventHandler(this.Showcheckbox_CheckedChanged);
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.Yellow;
            this.regButton.Font = new System.Drawing.Font("MV Boli", 10.8F);
            this.regButton.Location = new System.Drawing.Point(240, 329);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(139, 47);
            this.regButton.TabIndex = 10;
            this.regButton.Text = "Registration";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // Loginview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(636, 415);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.showcheckbox);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.useridtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loginview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginview";
            this.Load += new System.EventHandler(this.Loginview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox useridtextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.CheckBox showcheckbox;
        private System.Windows.Forms.Button regButton;
    }
}