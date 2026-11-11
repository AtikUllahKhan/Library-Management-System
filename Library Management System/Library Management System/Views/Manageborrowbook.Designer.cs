namespace Library_Management_System.Views
{
    partial class Manageborrowbook
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
            this.bookidtextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentidtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.returnbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.borrowbookdatagridview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.issuedatepicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.bookradiobutton = new System.Windows.Forms.RadioButton();
            this.studentradiobutton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.searchdatagridview = new System.Windows.Forms.DataGridView();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borrowbookdatagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // bookidtextbox
            // 
            this.bookidtextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidtextbox.Location = new System.Drawing.Point(161, 161);
            this.bookidtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.bookidtextbox.Multiline = true;
            this.bookidtextbox.Name = "bookidtextbox";
            this.bookidtextbox.Size = new System.Drawing.Size(204, 30);
            this.bookidtextbox.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(28, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 76;
            this.label4.Text = "Issue Date:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(48, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 75;
            this.label2.Text = "Book Id:";
            // 
            // studentidtextbox
            // 
            this.studentidtextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentidtextbox.Location = new System.Drawing.Point(161, 106);
            this.studentidtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.studentidtextbox.Multiline = true;
            this.studentidtextbox.Name = "studentidtextbox";
            this.studentidtextbox.Size = new System.Drawing.Size(204, 30);
            this.studentidtextbox.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(28, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 73;
            this.label1.Text = "Student id:";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.backbutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(671, 320);
            this.backbutton.Margin = new System.Windows.Forms.Padding(2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(140, 41);
            this.backbutton.TabIndex = 72;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // returnbutton
            // 
            this.returnbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.returnbutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.Location = new System.Drawing.Point(177, 320);
            this.returnbutton.Margin = new System.Windows.Forms.Padding(2);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(140, 41);
            this.returnbutton.TabIndex = 71;
            this.returnbutton.Text = "Return";
            this.returnbutton.UseVisualStyleBackColor = false;
            this.returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Maroon;
            this.deletebutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(344, 320);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(140, 41);
            this.deletebutton.TabIndex = 70;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.updatebutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(504, 320);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(2);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(140, 41);
            this.updatebutton.TabIndex = 69;
            this.updatebutton.Text = "Reset";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(59)))));
            this.insertbutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton.Location = new System.Drawing.Point(9, 320);
            this.insertbutton.Margin = new System.Windows.Forms.Padding(2);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(140, 41);
            this.insertbutton.TabIndex = 68;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // borrowbookdatagridview
            // 
            this.borrowbookdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowbookdatagridview.Location = new System.Drawing.Point(9, 375);
            this.borrowbookdatagridview.Margin = new System.Windows.Forms.Padding(2);
            this.borrowbookdatagridview.Name = "borrowbookdatagridview";
            this.borrowbookdatagridview.RowHeadersWidth = 51;
            this.borrowbookdatagridview.RowTemplate.Height = 24;
            this.borrowbookdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowbookdatagridview.Size = new System.Drawing.Size(802, 242);
            this.borrowbookdatagridview.TabIndex = 67;
            this.borrowbookdatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Borrowbookdatagridview_CellClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 41);
            this.label3.TabIndex = 66;
            this.label3.Text = "   Library Management System";
            // 
            // issuedatepicker
            // 
            this.issuedatepicker.CustomFormat = "yyyy/mm/dd";
            this.issuedatepicker.Location = new System.Drawing.Point(161, 214);
            this.issuedatepicker.Name = "issuedatepicker";
            this.issuedatepicker.Size = new System.Drawing.Size(204, 20);
            this.issuedatepicker.TabIndex = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbutton);
            this.groupBox1.Controls.Add(this.bookradiobutton);
            this.groupBox1.Controls.Add(this.studentradiobutton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.searchdatagridview);
            this.groupBox1.Controls.Add(this.searchtextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(426, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 234);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(59)))));
            this.searchbutton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Location = new System.Drawing.Point(290, 84);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(74, 28);
            this.searchbutton.TabIndex = 81;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // bookradiobutton
            // 
            this.bookradiobutton.AutoSize = true;
            this.bookradiobutton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookradiobutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookradiobutton.Location = new System.Drawing.Point(224, 84);
            this.bookradiobutton.Name = "bookradiobutton";
            this.bookradiobutton.Size = new System.Drawing.Size(58, 24);
            this.bookradiobutton.TabIndex = 86;
            this.bookradiobutton.TabStop = true;
            this.bookradiobutton.Text = "book";
            this.bookradiobutton.UseVisualStyleBackColor = true;
            // 
            // studentradiobutton
            // 
            this.studentradiobutton.AutoSize = true;
            this.studentradiobutton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentradiobutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.studentradiobutton.Location = new System.Drawing.Point(138, 84);
            this.studentradiobutton.Name = "studentradiobutton";
            this.studentradiobutton.Size = new System.Drawing.Size(80, 24);
            this.studentradiobutton.TabIndex = 85;
            this.studentradiobutton.TabStop = true;
            this.studentradiobutton.Text = "student";
            this.studentradiobutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(5, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 28);
            this.label6.TabIndex = 84;
            this.label6.Text = "Search type:";
            // 
            // searchdatagridview
            // 
            this.searchdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchdatagridview.Location = new System.Drawing.Point(0, 117);
            this.searchdatagridview.Name = "searchdatagridview";
            this.searchdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.searchdatagridview.Size = new System.Drawing.Size(382, 117);
            this.searchdatagridview.TabIndex = 83;
            this.searchdatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Searchdatagridview_CellClick);
            // 
            // searchtextbox
            // 
            this.searchtextbox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextbox.Location = new System.Drawing.Point(160, 39);
            this.searchtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.searchtextbox.Multiline = true;
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(204, 30);
            this.searchtextbox.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(9, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 81;
            this.label5.Text = "Search(name):";
            // 
            // Manageborrowbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(820, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.issuedatepicker);
            this.Controls.Add(this.bookidtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentidtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.borrowbookdatagridview);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manageborrowbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manageborrowbook";
            this.Load += new System.EventHandler(this.Manageborrowbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowbookdatagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bookidtextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentidtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.DataGridView borrowbookdatagridview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker issuedatepicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.RadioButton bookradiobutton;
        private System.Windows.Forms.RadioButton studentradiobutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView searchdatagridview;
        private System.Windows.Forms.TextBox searchtextbox;
        private System.Windows.Forms.Label label5;
    }
}