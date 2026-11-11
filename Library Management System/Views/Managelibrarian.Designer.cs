namespace Library_Management_System.Views
{
    partial class Managelibrarian
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
            this.label3 = new System.Windows.Forms.Label();
            this.managelibrariandatagridview = new System.Windows.Forms.DataGridView();
            this.insertbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.phonenotextbox = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.maleradiobutton = new System.Windows.Forms.RadioButton();
            this.femaleradiobutton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.answertextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.salarytextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managelibrariandatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "   Library Management System";
            // 
            // managelibrariandatagridview
            // 
            this.managelibrariandatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managelibrariandatagridview.Location = new System.Drawing.Point(9, 427);
            this.managelibrariandatagridview.Margin = new System.Windows.Forms.Padding(2);
            this.managelibrariandatagridview.Name = "managelibrariandatagridview";
            this.managelibrariandatagridview.RowHeadersWidth = 51;
            this.managelibrariandatagridview.RowTemplate.Height = 24;
            this.managelibrariandatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.managelibrariandatagridview.Size = new System.Drawing.Size(802, 190);
            this.managelibrariandatagridview.TabIndex = 5;
            this.managelibrariandatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Managelibrariandatagridview_CellClick);
            // 
            // insertbutton
            // 
            this.insertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(59)))));
            this.insertbutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton.Location = new System.Drawing.Point(9, 372);
            this.insertbutton.Margin = new System.Windows.Forms.Padding(2);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(140, 41);
            this.insertbutton.TabIndex = 8;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.updatebutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(177, 372);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(2);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(140, 41);
            this.updatebutton.TabIndex = 9;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Maroon;
            this.deletebutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(344, 372);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(140, 41);
            this.deletebutton.TabIndex = 10;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.resetbutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Location = new System.Drawing.Point(513, 372);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(2);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(140, 41);
            this.resetbutton.TabIndex = 11;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.backbutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(675, 372);
            this.backbutton.Margin = new System.Windows.Forms.Padding(2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(140, 41);
            this.backbutton.TabIndex = 12;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextbox.Location = new System.Drawing.Point(161, 104);
            this.nametextbox.Margin = new System.Windows.Forms.Padding(2);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(204, 30);
            this.nametextbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(44, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(44, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(44, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone No:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(47, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(47, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Address:";
            // 
            // emailtextbox
            // 
            this.emailtextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextbox.Location = new System.Drawing.Point(161, 159);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailtextbox.Multiline = true;
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(204, 30);
            this.emailtextbox.TabIndex = 20;
            // 
            // phonenotextbox
            // 
            this.phonenotextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenotextbox.Location = new System.Drawing.Point(161, 211);
            this.phonenotextbox.Margin = new System.Windows.Forms.Padding(2);
            this.phonenotextbox.Multiline = true;
            this.phonenotextbox.Name = "phonenotextbox";
            this.phonenotextbox.Size = new System.Drawing.Size(204, 30);
            this.phonenotextbox.TabIndex = 21;
            // 
            // addresstextbox
            // 
            this.addresstextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstextbox.Location = new System.Drawing.Point(161, 318);
            this.addresstextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addresstextbox.Multiline = true;
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(204, 30);
            this.addresstextbox.TabIndex = 22;
            // 
            // maleradiobutton
            // 
            this.maleradiobutton.AutoSize = true;
            this.maleradiobutton.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleradiobutton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.maleradiobutton.Location = new System.Drawing.Point(161, 265);
            this.maleradiobutton.Margin = new System.Windows.Forms.Padding(2);
            this.maleradiobutton.Name = "maleradiobutton";
            this.maleradiobutton.Size = new System.Drawing.Size(68, 27);
            this.maleradiobutton.TabIndex = 24;
            this.maleradiobutton.TabStop = true;
            this.maleradiobutton.Text = "Male";
            this.maleradiobutton.UseVisualStyleBackColor = true;
            // 
            // femaleradiobutton
            // 
            this.femaleradiobutton.AutoSize = true;
            this.femaleradiobutton.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleradiobutton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.femaleradiobutton.Location = new System.Drawing.Point(262, 265);
            this.femaleradiobutton.Margin = new System.Windows.Forms.Padding(2);
            this.femaleradiobutton.Name = "femaleradiobutton";
            this.femaleradiobutton.Size = new System.Drawing.Size(85, 27);
            this.femaleradiobutton.TabIndex = 25;
            this.femaleradiobutton.TabStop = true;
            this.femaleradiobutton.Text = "Female";
            this.femaleradiobutton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(442, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "S.Question:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(562, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 29);
            this.label9.TabIndex = 27;
            this.label9.Text = "What Is Your Pet Name?";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(442, 211);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 29);
            this.label10.TabIndex = 28;
            this.label10.Text = "S.Answer:";
            // 
            // answertextbox
            // 
            this.answertextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answertextbox.Location = new System.Drawing.Point(566, 213);
            this.answertextbox.Margin = new System.Windows.Forms.Padding(2);
            this.answertextbox.Multiline = true;
            this.answertextbox.Name = "answertextbox";
            this.answertextbox.Size = new System.Drawing.Size(204, 30);
            this.answertextbox.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(442, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "Password:";
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextbox.Location = new System.Drawing.Point(566, 266);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtextbox.Multiline = true;
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(204, 30);
            this.passwordtextbox.TabIndex = 31;
            // 
            // salarytextbox
            // 
            this.salarytextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarytextbox.Location = new System.Drawing.Point(566, 106);
            this.salarytextbox.Margin = new System.Windows.Forms.Padding(2);
            this.salarytextbox.Multiline = true;
            this.salarytextbox.Name = "salarytextbox";
            this.salarytextbox.Size = new System.Drawing.Size(204, 30);
            this.salarytextbox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(442, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Salary:";
            // 
            // Managelibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(820, 627);
            this.Controls.Add(this.salarytextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.answertextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.femaleradiobutton);
            this.Controls.Add(this.maleradiobutton);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.phonenotextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.managelibrariandatagridview);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Managelibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managelibrarian";
            this.Load += new System.EventHandler(this.Managelibrarian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managelibrariandatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView managelibrariandatagridview;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox phonenotextbox;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.RadioButton maleradiobutton;
        private System.Windows.Forms.RadioButton femaleradiobutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox answertextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox salarytextbox;
        private System.Windows.Forms.Label label7;
    }
}