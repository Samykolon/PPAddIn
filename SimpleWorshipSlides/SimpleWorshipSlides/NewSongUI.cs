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
        private String songtitle;
        private String songtexter;
        private String songcomposer;
        private String songtext;

        public string Songtitle
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

        public string Songtexter
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

        public string Songtext
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

        }
    }
}
