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
        public frmMain()
        {
            InitializeComponent();
        }

        private clsArtistList _ArtistList = new clsArtistList();
        

        private void updateDisplay()
        {
            string[] lcDisplayList = new string[_ArtistList.Count];

            lstArtists.DataSource = null;
            _ArtistList.Keys.CopyTo(lcDisplayList, 0);
            lstArtists.DataSource = lcDisplayList;
            lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ArtistList.NewArtist();
            if(clsCheckErrorMsg.MsgTrue == true)
            {
                MessageBox.Show("Artist added!");
            }
            else
            {
                MessageBox.Show("Duplicate Key!");
            }
            updateDisplay();
        }

        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;
            
            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
            {
                _ArtistList.EditArtist(lcKey);
                if(clsCheckErrorMsg.MsgTrue == false)
                {
                    clsCheckErrorMsg.MsgTrue = true;
                    MessageBox.Show("Sorry no artist by this name");
                }
                              
                updateDisplay();
                
                
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
                updateDisplay();
            }
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            _ArtistList = clsArtistList.Retrieve();
            if (clsCheckErrorMsg.MsgTrue == false)
            {
                MessageBox.Show("File Retrieve Error");
            }
            updateDisplay();
        }
    }
}