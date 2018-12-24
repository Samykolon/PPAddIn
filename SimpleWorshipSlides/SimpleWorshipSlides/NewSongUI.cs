using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWorshipSlides
{
    public partial class NewSongUI : Form
    {
        public string songtitle;
        private string songtexter;
        private string songcomposer;
        private string songtext;

        public string MSongtitle
        {
            get
            {
                return songtitle;
            }

            set
            {
                songtitle = value;
            }
        }

        public string MSongtexter
        {
            get
            {
                return songtexter;
            }

            set
            {
                songtexter = value;
            }
        }

        public string MSongcomposer
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

        public string MSongtext
        {
            get
            {
                return songtext;
            }

            set
            {
                songtext = value;
            }
        }

        public NewSongUI()
        {
            InitializeComponent();
        }

        private void NewSongUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            MSongtitle = TBTitle.Text;
            MSongtexter = TBTexter.Text;
            MSongcomposer = TBMusic.Text;
            MSongtext = TBSongText.Text;
        }
    }
}
