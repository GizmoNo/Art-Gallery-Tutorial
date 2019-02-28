using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        private float theWidth;
        private float theHeight;
        private string theType;

        [NonSerialized()]
        private static frmPhotograph sculptureDialog;

        public override void EditDetails()
        {
            if (sculptureDialog == null)
            {
                sculptureDialog = new frmPhotograph();
            }
            sculptureDialog.SetDetails(_Name, theDate, theValue, theWidth, theHeight, theType);
            if (sculptureDialog.ShowDialog() == DialogResult.OK)
            {
                sculptureDialog.GetDetails(ref _Name, ref theDate, ref theValue, ref theWidth, ref theHeight, ref theType);
            }

        }
    }
}
