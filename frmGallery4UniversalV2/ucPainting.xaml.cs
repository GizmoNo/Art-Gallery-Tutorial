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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace frmGallery4UniversalV2
{
    public sealed partial class ucPainting : IWorkControl
    {
        public ucPainting()
        {
            this.InitializeComponent();
        }

        public void PushData(clsAllWork prWork)
        {
            
            //clsPainting lcWork = (clsPainting)_Work;
            prWork.Width = Single.Parse(txtWidth.Text);
            prWork.Height = Single.Parse(txtHeight.Text);
            prWork.Type = txtType.Text;
        }

        public void UpdateControl(clsAllWork prWork)
        {

            //clsPainting lcWork = (clsPainting)_Work;
            txtWidth.Text = prWork.Width.ToString();
            txtHeight.Text = prWork.Height.ToString();
            txtType.Text = prWork.Type;
        }
            
    }
}
