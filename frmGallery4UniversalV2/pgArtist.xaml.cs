﻿using System;
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
    public sealed partial class pgArtist : Page
    {
        private clsArtist _Artist = new clsArtist();
        private string lcArtistName;

        public pgArtist()
        {
            this.InitializeComponent();
        }

        private void updateDisplay()
        {
            txtName.Text = _Artist.Name;
            txtSpeciality.Text = _Artist.Speciality;
            txtPhone.Text = _Artist.Phone;
            txtName.IsEnabled = string.IsNullOrEmpty(_Artist.Name);
            lstArt.ItemsSource = null;
            if (_Artist.WorksList != null)
                lstArt.ItemsSource = _Artist.WorksList;
        }

        private void pushData()
        {
            _Artist.Name = txtName.Text;
            _Artist.Speciality = txtSpeciality.Text;
            _Artist.Phone = txtPhone.Text;
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                //lcArtistName = _Artist.Name;

                base.OnNavigatedTo(e);
                if (e.Parameter != null)
                {
                    string lcArtistName = e.Parameter.ToString();
                    _Artist = await ServiceClient.GetArtistAsync(lcArtistName);
                    updateDisplay();
                }
                else
                    _Artist = new clsArtist();
            }
            catch (Exception)
            {
                txbMessage.Text = "An Error Occured";
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            saveArtist();
        }



        private async void saveArtist()
        {
            try
            {


                pushData();
                if (txtName.IsEnabled)
                {
                    txbMessage.Text +=
                        await ServiceClient.InsertArtistAsync(_Artist) + '\n';
                    txtName.IsEnabled = false;
                }
                else
                    txbMessage.Text +=
                        await ServiceClient.UpdateArtistAsync(_Artist) + '\n';
            }
            catch (Exception)
            {
                txbMessage.Text = "Save Error";
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            try
            {
                saveArtist();
            }
            catch (Exception)
            {
                txbMessage.Text = "An Error Occured";
            }

            
        }

        private void editWork(clsAllWork prWork)
        {
            if (prWork != null)
                Frame.Navigate(typeof(pgWork), prWork);
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            editWork(lstArt.SelectedItem as clsAllWork);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Popup lcArtworkChoicesPopup = new Popup();
            ucArtworkChoices lcArtworkChoices = new ucArtworkChoices();
            lcArtworkChoicesPopup.Child = lcArtworkChoices;
            lcArtworkChoicesPopup.HorizontalOffset = 130;
            lcArtworkChoicesPopup.VerticalOffset = 300;
            lcArtworkChoicesPopup.IsOpen = true;
            lcArtworkChoicesPopup.Closed += (s, e1) =>
            {
                clsAllWork lcWork = clsAllWork.NewWork((char)lcArtworkChoices.Tag);
                lcWork.ArtistName = _Artist.Name;
                editWork(lcWork);
            };
        }
    }
}
