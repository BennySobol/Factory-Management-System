using DrMelomad.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrMelomad.Win
{
    public partial class ConfigurationWin : Form
    {
        public ConfigurationWin()
        {
            InitializeComponent();
        }

        private void ConfigurationWin_Load(object sender, EventArgs e)
        {
            colorDialog1.Color = (Color)Settings.Default["color"];
            BackColor = (Color)Settings.Default["color"];
            switch (Int32.Parse(Settings.Default["dropMenuSpeed"].ToString()))
            {
                case 560:
                    dropMenuSpeedCB.SelectedIndex = 0;
                    break;
                case 70:
                    dropMenuSpeedCB.SelectedIndex = 1;
                    break;
                case 16:
                    dropMenuSpeedCB.SelectedIndex = 2;
                    break;
                case 5:
                    dropMenuSpeedCB.SelectedIndex = 3;
                    break;
                default:
                    break;
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            Settings.Default["color"] = colorDialog1.Color;

            switch (dropMenuSpeedCB.SelectedIndex)
            {
                case 0:
                    Settings.Default["dropMenuSpeed"] = 560;
                    break;
                case 1:
                    Settings.Default["dropMenuSpeed"] = 70;
                    break;
                case 2:
                    Settings.Default["dropMenuSpeed"] = 16;
                    break;
                case 3:
                    Settings.Default["dropMenuSpeed"] = 5;
                    break;
                default:
                    break;
            }
            Settings.Default.Save();
            Settings.Default["color"] = colorDialog1.Color;
            MessageBox.Show("ההגדרות שונו בהצלחה");
            this.Refresh();
        }


        private void clearBTN_Click(object sender, EventArgs e)
        {
            Settings.Default["color"] = (Color)SystemColors.Control;
            Settings.Default["dropMenuSpeed"] = 70;
            Settings.Default.Save();
            BackColor = (Color)Settings.Default["color"];
            MessageBox.Show("ההגדרות אופסו בהצלחה");
        }

        private void colorChoseBTN_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
        }
    }
}
