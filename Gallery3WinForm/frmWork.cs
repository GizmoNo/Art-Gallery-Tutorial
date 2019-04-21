using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gallery3WinForm
{
    public partial class frmWork : Form
    {

        public frmWork()
        {
            InitializeComponent();
        }

        protected clsAllWork _Work;

        public void SetDetails(clsAllWork prWork)
        {
            _Work = prWork;
            updateForm();
            ShowDialog();
        }
               
        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                pushData();
                if (txtName.Enabled)
                    MessageBox.Show(await ServiceClient.InsertWorkAsync(_Work));
                else
                    MessageBox.Show(await ServiceClient.UpdateWorkAsync(_Work));
                Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        public virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtName.Text = _Work.Name;
            dtpDateTime.Text = _Work.Date.ToShortDateString();
            txtValue.Text = _Work.Value.ToString();
            txtName.Enabled = string.IsNullOrEmpty(_Work.Name);
        }

        protected virtual void pushData()
        {
            _Work.Name = txtName.Text;
            _Work.Date = DateTime.Parse(dtpDateTime.Text);
            _Work.Value = decimal.Parse(txtValue.Text);
        }

        public delegate void LoadWorkFromDelegate(clsAllWork prWork);
        public static Dictionary<char, Delegate> _WorkForm = new Dictionary<char, Delegate>
        {
            {'P', new LoadWorkFromDelegate(frmPainting.Run) },
            {'H', new LoadWorkFromDelegate(frmPhotograph.Run) },
            {'S', new LoadWorkFromDelegate(frmSculpture.Run) }
        };

        public static void DispatchWorkForm(clsAllWork prWork)
        {
            _WorkForm[prWork.WorkType].DynamicInvoke(prWork);
        }
    
    }
}