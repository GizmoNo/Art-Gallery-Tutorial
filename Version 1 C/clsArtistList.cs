using System;
using System.Collections.Generic;


namespace Version_1_C
{
    [Serializable()] 
    public class clsArtistList : SortedList<string, clsArtist>
    {

        private const string _FileName = "galleryV3.xml";

        private string _GalleryName;

        public string GalleryName { get => _GalleryName; set => _GalleryName = value; }

        //public void EditArtist(string prKey)
        //{
        //    clsArtist lcArtist;
        //    try
        //    {
        //        lcArtist = this[prKey];
        //        if (lcArtist != null)
        //            lcArtist.EditDetails();
        //    }
        //    catch (Exception)
        //    {
        //        //MsgTrue = false;
        //        clsCheckErrorMsg.MsgTrue = false;
        //    }





        //}



        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsArtist lcArtist in Values)
            {
                lcTotal += lcArtist.TotalValue;
            }
            return lcTotal;
        }

        public void Save()
        {
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                lcFormatter.Serialize(lcFileStream, this);
                lcFileStream.Close();
            }
            catch (Exception e)
            {
                clsCheckErrorMsg.MsgTrue = false;
                
            }
        }

        public static clsArtistList Retrieve()
        {
            clsArtistList lcArtistList;
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                lcArtistList = (clsArtistList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
                return lcArtistList;
            }

            catch (Exception e)
            {
                               
                
                lcArtistList = new clsArtistList();
                clsCheckErrorMsg.MsgTrue = false;
                return lcArtistList;
            }
        }

        
    }


}
