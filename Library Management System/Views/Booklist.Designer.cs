namespace Library_Management_System.Views
{
    partial class Booklist
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
            this.booklistdatagridview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booklistdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // booklistdatagridview
            // 
            this.booklistdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booklistdatagridview.Location = new System.Drawing.Point(51, 122);
            this.booklistdatagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.booklistdatagridview.Name = "booklistdatagridview";
            this.booklistdatagridview.RowHeadersWidth = 51;
            this.booklistdatagridview.RowTemplate.Height = 24;
            this.booklistdatagridview.Size = new System.Drawing.Size(999, 523);
            this.booklistdatagridview.TabIndex = 0;
            this.booklistdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Booklistdatagridview_CellContentClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "   Library Management System";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.backbutton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(427, 683);
            this.backbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(187, 50);
            this.backbutton.TabIndex = 13;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Booklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1093, 772);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.booklistdatagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Booklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booklist";
            this.Load += new System.EventHandler(this.Booklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booklistdatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booklistdatagridview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backbutton;
    }
}