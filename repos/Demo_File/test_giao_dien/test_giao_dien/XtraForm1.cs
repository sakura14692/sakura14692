using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_giao_dien
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {


        ImageCollection img;
        public XtraForm1()
        {
            //defaultLookAndFeel1.LookAndFeel.SetSkinStyle("");
            InitializeComponent();
            ImageCollection img;
            img = new ImageCollection();
            imageComboBoxEdit1.Properties.SmallImages = img;
            
            for (int i = 0; i < SkinManager.Default.Skins.Count; i++)
            {
            
                string skinName = SkinManager.Default.Skins[i].SkinName;
               
                img.AddImage(SkinCollectionHelper.GetSkinIcon(skinName, SkinIconsSize.Small), skinName);
                imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem(skinName, i,i));
                if (skinName == Properties.Settings.Default.theme)
                {
                    imageComboBoxEdit1.SelectedIndex = i;
                }

            }

            //defaultLookAndFeel1.LookAndFeel.SetSkinStyle(skinName);

        }
        int a;
        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ImageComboBoxEdit edit = sender as ImageComboBoxEdit;
            this.Text = edit.Text + " index: " + edit.SelectedIndex.ToString(); ;
            a = edit.SelectedIndex;
            string giao_dien = edit.Text;
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(giao_dien);
            Properties.Settings.Default.theme = giao_dien;
            

            // Lưu lại
            Properties.Settings.Default.Save();




        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            
            imageComboBoxEdit1.SelectedIndex = a;

            string skinName = SkinManager.Default.Skins[a].SkinName;
            //img.AddImage(SkinCollectionHelper.GetSkinIcon(skinName, SkinIconsSize.Small), skinName);
            //imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem(skinName, 1, 1));
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(skinName);
            
        }

            }
}