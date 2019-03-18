using System;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Version_1_C
{
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }
        private static Dictionary<clsArtist, frmArtist> _ArtistFormList = new Dictionary<clsArtist, frmArtist>();
        private static readonly string ArtistNameChangePrompt = "Enter a New Artist Name";
        private clsArtist _Artist;
        private clsWorksList _WorksList;
        public delegate void Notify(string prArtistName);
        public event Notify ArtistNameChanged;
       

        private void updateDisplay()
        {
            //txtName.Enabled = txtName.Text == "";
            if (_Artist.SortOrder == 0)
            {
                _WorksList.SortByName();
                rbByName.Checked = true;
            }
            else
            {
                _WorksList.SortByDate();
                rbByDate.Checked = true;
            }

            lstWorks.DataSource = null;
            lstWorks.DataSource = _WorksList;
            lblTotal.Text = Convert.ToString(_WorksList.GetTotalValue());
            frmMain.Instance.UpdateDisplay();
        }

        public void SetDetails(clsArtist prArtist)
        {
            
            _Artist = prArtist;
            txtName.Enabled = string.IsNullOrEmpty(_Artist.Name);
            updateForm();
            updateDisplay();
            frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            updateTitle(_Artist.ArtistList.GalleryName);
            Show();
        }
                
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            _WorksList.DeleteWork(lstWorks.SelectedIndex);
            updateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lcReply = new InputBox(clsWork.FACTORY_PROMPT).Answer;
            if (!string.IsNullOrEmpty(lcReply))
            {
                _WorksList.AddWork(lcReply[0]);
                updateDisplay();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtName.Enabled)
                    {
                        _Artist.NewArtist();
                        MessageBox.Show("Artist Added!", "Success");
                        frmMain.Instance.UpdateDisplay();
                        txtName.Enabled = false;
                    }
                    Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
            
        }

        public virtual Boolean isValid()
        {
            if (txtName.Enabled && txtName.Text != "")
                if (_Artist.IsDuplicate(txtName.Text))
                {
                    MessageBox.Show("Artist with that name already exists!");
                    return false;
                }
                else
                    return true;
            else
                return true;
        }

        private void lstWorks_DoubleClick(object sender, EventArgs e)
        {
            int lcIndex = lstWorks.SelectedIndex;
                        
                _WorksList.EditWork(lcIndex);
                if(clsCheckErrorMsg.MsgTrue == false)
                {
                    MessageBox.Show("Sorry no work selected please select the work you wish to edit");
                    clsCheckErrorMsg.MsgTrue = true;
                }
                updateDisplay();
           
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            _Artist.SortOrder = Convert.ToByte(rbByDate.Checked);
            updateDisplay();
        }

        private void updateForm()
        {
            txtName.Text = _Artist.Name;
            txtSpeciality.Text = _Artist.Speciality;
            txtPhone.Text = _Artist.Phone;
            _WorksList = _Artist.WorksList;
            _Artist.SortOrder = _WorksList.SortOrder;
        }

        private void pushData()
        {
            _Artist.Name = txtName.Text;
            _Artist.Speciality = txtSpeciality.Text;
            _Artist.Phone = txtPhone.Text;
            _Artist.SortOrder = _WorksList.SortOrder;
        }

        public static void Run(clsArtist prArtist)
        {
            frmArtist lcArtistForm;
            if(!_ArtistFormList.TryGetValue(prArtist, out lcArtistForm))
            {
                lcArtistForm = new frmArtist();
                _ArtistFormList.Add(prArtist, lcArtistForm);
                lcArtistForm.SetDetails(prArtist);
            }
            else
            {
                lcArtistForm.Show();
                lcArtistForm.Activate();
            }
        }

        private void updateTitle(string prGalleryName)
        {
            if (!string.IsNullOrEmpty(prGalleryName))
                Text = "Artist Details -" + prGalleryName;
        }

        private void frmArtist_Load(object sender, EventArgs e)
        {
            ArtistNameChanged += new Notify(updateTitle);
            ArtistNameChanged(_WorksList.ArtistName);
        }

        private void btnChangeArtistName_Click(object sender, EventArgs e)
        {
            string lcReply = new InputBox(ArtistNameChangePrompt).Answer;
            if (!string.IsNullOrEmpty(lcReply))
            {
                _WorksList.ArtistName = lcReply;
                ArtistNameChanged(_WorksList.ArtistName);
            }
        }
    }
}