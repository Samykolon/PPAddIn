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
        private string songtext;
        private string songtitle;
        private string songcomposer;
        private string songwriter;
        

        public string Songtext
        {
            get { return songtext; }
            set { songtext = value; }
        }

        public string Songtitle
        {
            get { return songtitle; }
            set { songtitle = value; }
        }

        public string Songcomposer
        {
            get
            {
                return songcomposer;
            }

            set
            {
                songcomposer = value;
            }
        }

        public string Songwriter
        {
            get
            {
                return songwriter;
            }

            set
            {
                songwriter = value;
            }
        }

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void BNewSong_Click(object sender, RibbonControlEventArgs e)
        {
            DialogResult dr = new DialogResult();
            Form FNewSong = new NewSongUI();
            dr = FNewSong.ShowDialog();

            if(dr == DialogResult.OK)
            {
                this.Songtitle = FNewSong.MSongtitle;
            }

        }
    }
}
