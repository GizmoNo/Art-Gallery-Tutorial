using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class pgMain : Page
    {
        public pgMain()
        {
            this.InitializeComponent();
        }

        
        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                lstArtists.ItemsSource = await ServiceClient.GetArtistNamesAsync();
            }
            catch (Exception)
            {
                txbMessage.Text = "An Error has occored while loading. Contact Your Administrator.";
            }

            
        }

        private void editArtist()
        {
            if (lstArtists.SelectedItem != null)
                Frame.Navigate(typeof(pgArtist), lstArtists.SelectedItem);
        }

        private void addArtist()
        {
            if (lstArtists.SelectedItem == null)
                Frame.Navigate(typeof(pgArtist));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            editArtist();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            addArtist();
        }

        private async void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            string lcArtistName = Convert.ToString(lstArtists.SelectedItem);
            if (!string.IsNullOrEmpty(lcArtistName))
            {
                MessageDialog lcMessageBox = new MessageDialog("Are you sure");
                lcMessageBox.Commands.Add(new UICommand("Yes", async x =>
                    txbMessage.Text = await ServiceClient.DeleteArtistAsync(lcArtistName) + '\n'));
                lcMessageBox.Commands.Add(new UICommand("No"));

                await lcMessageBox.ShowAsync();
                lstArtists.ItemsSource = await ServiceClient.GetArtistNamesAsync();
            }
        }
    }
}
