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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout newForm = new FormAbout();
            newForm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm newForm = new SettingsForm();
            newForm.Show();
        }
    }
}
