using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace frmGallery4UniversalV2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgWork : Page
    {

        private delegate void LoadWorkControlDelegate(clsAllWork prWork);
        private Dictionary<char, Delegate> _WorkContent;

        public pgWork()
        {
            this.InitializeComponent();

            _WorkContent = new Dictionary<char, Delegate>
            {
                {'P', new LoadWorkControlDelegate(RunPainting) },
                {'H', new LoadWorkControlDelegate(RunSculpture) },
                {'S', new LoadWorkControlDelegate(RunPhotoGraph) }
            };
        }

        private clsAllWork _Work = new clsAllWork();
        


        private void updatePage(clsAllWork prWork)
        {
            _Work = prWork;
            txtName.Text = _Work.Name;
            txtDate.Text = _Work.Date.ToString("d");
            txtValue.Text = _Work.Value.ToString();
            txtName.IsEnabled = string.IsNullOrEmpty(_Work.Name);
            (ctcWorkSpecs.Content as
                IWorkControl).UpdateControl(prWork);
        }

        private void pushData()
        {
            _Work.Name = txtName.Text;
            _Work.Date = DateTime.Parse(txtDate.Text);
            _Work.Value = decimal.Parse(txtValue.Text);
            (ctcWorkSpecs.Content as
                IWorkControl).PushData(_Work);
        }

        private void RunPainting(clsAllWork prWork)
        {
            ctcWorkSpecs.Content = new ucPainting();
            lblEdit.Text = "Edit Painting";
        }

        private void RunSculpture(clsAllWork prWork)
        {
            ctcWorkSpecs.Content = new ucSculpture();
            lblEdit.Text = "Edit Sculpture";
        }

        private void RunPhotoGraph(clsAllWork prWork)
        {
            ctcWorkSpecs.Content = new ucPhotoGraph();
            lblEdit.Text = "Edit PhotoGraph";
        }



        private void dispatchWorkContent(clsAllWork prWork)
        {
            _WorkContent[prWork.WorkType].DynamicInvoke(prWork);
            updatePage(prWork);
        }

        private async void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pushData();
                if (txtName.IsEnabled)
                    await ServiceClient.InsertWorkAsync(_Work);
                else
                    await ServiceClient.UpdateWorkAsync(_Work);
                Frame.GoBack();
            }
            catch (Exception)
            {
                txbErrors.Text = "An Error Has Occurred";
            }
            

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            dispatchWorkContent(e.Parameter as clsAllWork);
        }
    }
}
