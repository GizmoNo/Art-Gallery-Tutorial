using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;
        private byte _SortOrder;


        private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;
        
        //private static frmArtist lcArtistDialog = new frmArtist();

        public string Name { get => _Name; set => _Name = value; }
        public string Speciality { get => _Speciality; set => _Speciality = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public decimal TotalValue { get { return _WorksList.GetTotalValue(); } }
        public clsWorksList WorksList { get => _WorksList;}
        public clsArtistList ArtistList { get => _ArtistList; set => _ArtistList = value; }
        public byte SortOrder { get => _SortOrder; set => _SortOrder = value; }

        public clsArtist(clsArtistList prArtistList)
        {
            _WorksList = new clsWorksList();
            _ArtistList = prArtistList;
            //EditDetails();
        }
        
        //public void EditDetails()
        //{
        //    lcArtistDialog.SetDetails(this);
            
        //    _TotalValue = _WorksList.GetTotalValue();
            
        //}

        public bool IsDuplicate(string prArtistName)
        {
            return _ArtistList.ContainsKey(prArtistName);
        }

        public void NewArtist()
        {



            if (!string.IsNullOrEmpty(Name))
            {
                _ArtistList.Add(Name, this);
                clsCheckErrorMsg.MsgTrue = true;
            }
            else
            {
                clsCheckErrorMsg.MsgTrue = false;
                throw new Exception("No Artist Name Entered");
                
            }
                










        }


    }
}
