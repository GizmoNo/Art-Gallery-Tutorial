namespace Gallery3WinForm
{
    partial class frmArtist
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.optSort = new System.Windows.Forms.GroupBox();
            this.rbByDate = new System.Windows.Forms.RadioButton();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.lstWorks = new System.Windows.Forms.ListBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnChangeArtistName = new System.Windows.Forms.Button();
            this.optSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(207, 287);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 20);
            this.lblTotal.TabIndex = 27;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(100, 287);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(85, 20);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Total Value";
            // 
            // optSort
            // 
            this.optSort.Controls.Add(this.rbByDate);
            this.optSort.Controls.Add(this.rbByName);
            this.optSort.Location = new System.Drawing.Point(132, 100);
            this.optSort.Margin = new System.Windows.Forms.Padding(4);
            this.optSort.Name = "optSort";
            this.optSort.Padding = new System.Windows.Forms.Padding(4);
            this.optSort.Size = new System.Drawing.Size(181, 59);
            this.optSort.TabIndex = 25;
            this.optSort.TabStop = false;
            this.optSort.Text = "Sort By";
            // 
            // rbByDate
            // 
            this.rbByDate.Location = new System.Drawing.Point(107, 20);
            this.rbByDate.Margin = new System.Windows.Forms.Padding(4);
            this.rbByDate.Name = "rbByDate";
            this.rbByDate.Size = new System.Drawing.Size(64, 30);
            this.rbByDate.TabIndex = 1;
            this.rbByDate.Text = "Date";
            this.rbByDate.CheckedChanged += new System.EventHandler(this.rbByDate_CheckedChanged);
            // 
            // rbByName
            // 
            this.rbByName.Location = new System.Drawing.Point(11, 20);
            this.rbByName.Margin = new System.Windows.Forms.Padding(4);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(75, 30);
            this.rbByName.TabIndex = 0;
            this.rbByName.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(228, 316);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 39);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 316);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 316);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(15, 149);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(107, 20);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Works";
            // 
            // lstWorks
            // 
            this.lstWorks.ItemHeight = 16;
            this.lstWorks.Location = new System.Drawing.Point(15, 169);
            this.lstWorks.Margin = new System.Windows.Forms.Padding(4);
            this.lstWorks.Name = "lstWorks";
            this.lstWorks.Size = new System.Drawing.Size(297, 100);
            this.lstWorks.TabIndex = 20;
            this.lstWorks.DoubleClick += new System.EventHandler(this.lstWorks_DoubleClick);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(100, 70);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 22);
            this.txtPhone.TabIndex = 19;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(15, 70);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 20);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Contact Ph";
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Location = new System.Drawing.Point(100, 41);
            this.txtSpeciality.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.Size = new System.Drawing.Size(212, 22);
            this.txtSpeciality.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(15, 41);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 20);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Speciality";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 11);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 22);
            this.txtName.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(15, 11);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 20);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Name";
            // 
            // btnChangeArtistName
            // 
            this.btnChangeArtistName.Location = new System.Drawing.Point(18, 362);
            this.btnChangeArtistName.Name = "btnChangeArtistName";
            this.btnChangeArtistName.Size = new System.Drawing.Size(295, 31);
            this.btnChangeArtistName.TabIndex = 28;
            this.btnChangeArtistName.Text = "Change Artist Gallery Name";
            this.btnChangeArtistName.UseVisualStyleBackColor = true;
            this.btnChangeArtistName.Click += new System.EventHandler(this.btnChangeArtistName_Click);
            // 
            // frmArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 399);
            this.Controls.Add(this.btnChangeArtistName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.optSort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lstWorks);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtSpeciality);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArtist";
            this.Text = "frmArtist";
            this.Load += new System.EventHandler(this.frmArtist_Load);
            this.optSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox optSort;
        internal System.Windows.Forms.RadioButton rbByDate;
        internal System.Windows.Forms.RadioButton rbByName;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ListBox lstWorks;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtSpeciality;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnChangeArtistName;
    }
}