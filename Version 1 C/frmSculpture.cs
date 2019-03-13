using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmSculpture : Version_1_C.frmWork
    {

        public static readonly frmSculpture Sculpture = new frmSculpture();

        private frmSculpture()
        {
            InitializeComponent();
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsSculpture lcWork = (clsSculpture)_Work;
            txtWeight.Text = lcWork.Weight.ToString();
            txtMaterial.Text = lcWork.Material;
            
        }

        protected override void pushData()
        {
            base.pushData();
            clsSculpture lcWork = (clsSculpture)_Work;
            lcWork.Weight = Single.Parse(txtWeight.Text);
            lcWork.Material = txtMaterial.Text;
            
        }
        //public virtual void SetDetails(string prName, DateTime prDate, decimal prValue,
        //                               float prWeight, string prMaterial)
        //{
        //    base.SetDetails(prName, prDate, prValue);
        //    txtWeight.Text = Convert.ToString(prWeight);
        //    txtMaterial.Text = Convert.ToString(prMaterial);

        //}

        //public virtual void GetDetails(ref string prName, ref DateTime prDate, ref decimal prValue,
        //                               ref float prWeight, ref string prMaterial)
        //{
        //    base.GetDetails(ref prName, ref prDate, ref prValue);
        //    prWeight = Convert.ToSingle(txtWeight.Text);
        //    prMaterial = Convert.ToString(txtMaterial.Text);

        //}

    }
}

