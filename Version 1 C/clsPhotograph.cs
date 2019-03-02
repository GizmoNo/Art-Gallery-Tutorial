using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

        [NonSerialized()]
        private static frmPhotograph sculptureDialog;

        public override void EditDetails()
        {
            if (sculptureDialog == null)
            {
                sculptureDialog = new frmPhotograph();
            }
            sculptureDialog.SetDetails(_Name, _Date, _Value, _Width, _Height, _Type);
            if (sculptureDialog.ShowDialog() == DialogResult.OK)
            {
                sculptureDialog.GetDetails(ref _Name, ref _Date, ref _Value, ref _Width, ref _Height, ref _Type);
            }

        }
    }
}
