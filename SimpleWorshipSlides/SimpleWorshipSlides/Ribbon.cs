using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using SimpleWorshipSlides;


namespace SimpleWorshipSlides
{
    public partial class Ribbon
    {
        private String songtext;
        private String songtitle;

        public String Songtext
        {
            get { return songtext; }
            set { songtext = value; }
        }

        public string Songtitle
        {
            get { return songtitle; }
            set { songtitle = value; }
        }

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void BNewSong_Click(object sender, RibbonControlEventArgs e)
        {
            Form FNewSong = new NewSongUI();
            FNewSong.Show();
        }
    }
}
