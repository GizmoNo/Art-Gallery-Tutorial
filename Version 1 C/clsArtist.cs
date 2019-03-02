using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;
        
        private decimal _TotalValue;

        private clsWorksList lcWorksList;
        private clsArtistList lcArtistList;
        
        private static frmArtist lcArtistDialog = new frmArtist();
        

        public clsArtist(clsArtistList prArtistList)
        {
            lcWorksList = new clsWorksList();
            lcArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            lcArtistDialog.SetDetails(_Name, _Speciality, _Phone, lcWorksList, lcArtistList);
            if (lcArtistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lcArtistDialog.GetDetails(ref _Name, ref _Speciality, ref _Phone);
                _TotalValue = lcWorksList.GetTotalValue();
            }
        }

        public string GetKey()
        {
            return _Name;
        }

        public decimal GetWorksValue()
        {
            return _TotalValue;
        }
    }
}
