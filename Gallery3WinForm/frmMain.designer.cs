namespace Gallery3WinForm
{
    partial class frmMain
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
            this.lblValue = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstArtists = new System.Windows.Forms.ListBox();
            this.btnChngGalleryName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(116, 272);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(91, 20);
            this.lblValue.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(23, 272);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 20);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Total Value";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(215, 262);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 39);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(215, 85);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(215, 36);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 39);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(23, 16);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(181, 20);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Artists";
            // 
            // lstArtists
            // 
            this.lstArtists.ItemHeight = 16;
            this.lstArtists.Location = new System.Drawing.Point(23, 36);
            this.lstArtists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstArtists.Name = "lstArtists";
            this.lstArtists.Size = new System.Drawing.Size(180, 212);
            this.lstArtists.TabIndex = 7;
            this.lstArtists.DoubleClick += new System.EventHandler(this.lstArtists_DoubleClick);
            // 
            // btnChngGalleryName
            // 
            this.btnChngGalleryName.Location = new System.Drawing.Point(215, 131);
            this.btnChngGalleryName.Name = "btnChngGalleryName";
            this.btnChngGalleryName.Size = new System.Drawing.Size(107, 42);
            this.btnChngGalleryName.TabIndex = 14;
            this.btnChngGalleryName.Text = "Change Gallery Name";
            this.btnChngGalleryName.UseVisualStyleBackColor = true;
            this.btnChngGalleryName.Click += new System.EventHandler(this.btnChngGalleryName_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 311);
            this.Controls.Add(this.btnChngGalleryName);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lstArtists);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Gallery (v1 C)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblValue;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox lstArtists;
        private System.Windows.Forms.Button btnChngGalleryName;
    }
}

