using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Matthias Otto, NMIT, 2010-2016
        /// </summary>
        /// 

        private static readonly frmMain _Instance = new frmMain();

        private frmMain()
        {
            InitializeComponent();
        }

        private clsArtistList _ArtistList = new clsArtistList();
        public delegate void Notify(string prGalleryName);
        public event Notify GalleryNameChanged;
        private static readonly string GalleryNameChangePrompt = "Enter A New Gallery Name";
        public static frmMain Instance => _Instance;

        public void UpdateDisplay()
        {
            string[] lcDisplayList = new string[_ArtistList.Count];

            lstArtists.DataSource = null;
            _ArtistList.Keys.CopyTo(lcDisplayList, 0);
            lstArtists.DataSource = lcDisplayList;
            lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmArtist.Run(new clsArtist(_ArtistList));

        }

      
        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;
            
            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
            {
                frmArtist.Run(_ArtistList[lcKey]);
                
                if(clsCheckErrorMsg.MsgTrue == false)
                {
                    clsCheckErrorMsg.MsgTrue = true;
                    MessageBox.Show("Sorry no artist by this name");
                }
                           
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _ArtistList.Save();
            if(clsCheckErrorMsg.MsgTrue == false)
            {
                MessageBox.Show("File Save Error");
            }
            else
            {
                Close();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
            {
                lstArtists.ClearSelected();
                _ArtistList.Remove(lcKey);
                UpdateDisplay();
            }
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            _ArtistList = clsArtistList.Retrieve();
            if (clsCheckErrorMsg.MsgTrue == false)
            {
                MessageBox.Show("File Retrieve Error");
            }
            UpdateDisplay();
            GalleryNameChanged += new Notify(updateTitle);
            GalleryNameChanged(_ArtistList.GalleryName); // Event Raising!
        }

        private void updateTitle(string prGalleryName)
        {
            if (!string.IsNullOrEmpty(prGalleryName))
                Text = "Gallery - " + prGalleryName;
        }

        private void btnChngGalleryName_Click(object sender, EventArgs e)
        {
            string lcReply = new InputBox(GalleryNameChangePrompt).Answer;
            if (!string.IsNullOrEmpty(lcReply))
            {
                _ArtistList.GalleryName = lcReply;
                GalleryNameChanged(_ArtistList.GalleryName);
            }
            
        }
    }
}