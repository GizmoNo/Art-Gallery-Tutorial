using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery3WinForm
{
    public class clsArtist
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Phone { get; set; }

        public List<clsAllWork> WorksList { get; set; }     
    }

    public class clsAllWork
    {

        public static readonly string FACTORY_PROMPT = "Enter P for Painting, S for Sculpture and H for Photograph";

        public char WorkType { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public string Type { get; set; }
        public float? Weight { get; set; }
        public string Material { get; set; }
        public string ArtistName { get; set; }


        public static clsAllWork NewWork(char prChoice)
        {
            return new clsAllWork()
            {
                WorkType = Char.ToUpper(prChoice), Date = DateTime.Now
            };
            //switch (char.ToUpper(prChoice))
            //{
            //    case 'P': return new clsPainting();
            //    case 'S': return new clsSculpture();
            //    case 'H': return new clsPhotograph();
            //    default: return null;
            //}
            
        }


        public override string ToString()
        {
            return Name + "\t" + Date.ToShortDateString();
        }
    }



    

}
