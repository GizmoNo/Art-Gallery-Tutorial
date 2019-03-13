using System;


namespace Version_1_C
{
    [Serializable()] 
    public class clsPainting : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

        [NonSerialized()]
        private frmPainting _paintDialog;

        public float Width { get => _Width; set => _Width = value; }
        public float Height { get => _Height; set => _Height = value; }
        public string Type { get => _Type; set => _Type = value; }

        public override void EditDetails()
        {
            if (_paintDialog == null)
                _paintDialog = frmPainting.Painting;
           _paintDialog.SetDetails(this);
            
            
        }
    }
}
