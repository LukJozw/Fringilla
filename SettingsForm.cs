using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fringilla
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitializeSettingsData();
        }

        public void InitializeSettingsData()
        {
            redUpDown.Value = Properties.Settings.Default.redCoefficient;
            greenUpDown.Value = Properties.Settings.Default.greenCoefficient;
            blueUpDown.Value = Properties.Settings.Default.blueCoefficient;
            vectLegthUpDown.Value = Properties.Settings.Default.filterLength;
            loopsUpDown.Value = Properties.Settings.Default.filterLoops;
            polyUpDown.Value = Fringilla.Properties.Settings.Default.wavePoly;
            monoUpDown.Value = Fringilla.Properties.Settings.Default.waveMono;
        }

        private void redUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.redCoefficient = redUpDown.Value;
        }

        private void greenUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.greenCoefficient = greenUpDown.Value;
        }

        private void blueUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.blueCoefficient = blueUpDown.Value;
        }

        private void btnColorDefault_Click(object sender, EventArgs e)
        {
            redUpDown.Value = 0.30M;
            greenUpDown.Value = 0.59M;
            blueUpDown.Value = 0.11M;
        }

        private void btnSmallFilter_Click(object sender, EventArgs e)       // settings 3 x 3
        {
            vectLegthUpDown.Value = 7;
            loopsUpDown.Value = 60;
        }

        private void btnMedFilter_Click(object sender, EventArgs e)         // settings = 9 x 9
        {
            vectLegthUpDown.Value = 19;
            loopsUpDown.Value = 120;
        }

        private void btnHighFilt_Click(object sender, EventArgs e)          // settings = 11 x 11
        {
            vectLegthUpDown.Value = 23;
            loopsUpDown.Value = 240;
        }

        private void vectLegthUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.filterLength = (int)vectLegthUpDown.Value;
        }

        private void loopsUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.filterLoops = (int)loopsUpDown.Value;
        }
        private void polyUpDown_ValueChanged(object sender, EventArgs e)
        {
            Fringilla.Properties.Settings.Default.wavePoly = polyUpDown.Value;
        }

        private void monoUpDown_ValueChanged(object sender, EventArgs e)
        {
            Fringilla.Properties.Settings.Default.waveMono = monoUpDown.Value;
        }

        private void btnColorRed_Click(object sender, EventArgs e)
        {
            redUpDown.Value = 1.00M;
            greenUpDown.Value = 0.00M;
            blueUpDown.Value = 0.00M;
        }

        private void btnWlenRed_Click(object sender, EventArgs e)
        {
            monoUpDown.Value = 650;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monoUpDown.Value = 534;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            polyUpDown.Value = 540;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            monoUpDown.Value = 594;
        }

        private void btnBitmap_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if(diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxBitmap.Text = diag.SelectedPath;
                Fringilla.Properties.Settings.Default.dirBitmap = diag.SelectedPath;
            }
            else
            {
                textBoxBitmap.Text = "";
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxReports.Text = diag.SelectedPath;
                Fringilla.Properties.Settings.Default.dirReport = diag.SelectedPath;
            }
            else
            {
                textBoxBitmap.Text = "";
            }
        }
    }
}
