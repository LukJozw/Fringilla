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
    }
}
