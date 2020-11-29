using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Sort_Visualization
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Chưa có code", "Sort Visualization", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Chưa có code", "Sort Visualization", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void toggleDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleDarkTheme.CheckState.ToString() == "Checked")
            {
                rdbtBubbleSort.Theme = MetroThemeStyle.Dark;
                rdbtInsertionSort.Theme = MetroThemeStyle.Dark;
                rdbtSlectionSort.Theme = MetroThemeStyle.Dark;
                panelAnimationArea.Theme = MetroThemeStyle.Dark;
                txboxSortData.Theme = MetroThemeStyle.Dark;
                btRandom.Theme = MetroThemeStyle.Dark;
                btSort.Theme = MetroThemeStyle.Dark;
                lbDarkTheme.Theme = MetroThemeStyle.Dark;
                lbAuthor.Theme = MetroThemeStyle.Dark;
                lbSlow.Theme = MetroThemeStyle.Dark;
                lbFast.Theme = MetroThemeStyle.Dark;
                trkbarAnimationSpeed.Theme = MetroThemeStyle.Dark;
                toggleDarkTheme.Theme = MetroThemeStyle.Dark;
                this.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                rdbtBubbleSort.Theme = MetroThemeStyle.Light;
                rdbtInsertionSort.Theme = MetroThemeStyle.Light;
                rdbtSlectionSort.Theme = MetroThemeStyle.Light;
                panelAnimationArea.Theme = MetroThemeStyle.Light;
                txboxSortData.Theme = MetroThemeStyle.Light;
                btRandom.Theme = MetroThemeStyle.Light;
                btSort.Theme = MetroThemeStyle.Light;
                lbDarkTheme.Theme = MetroThemeStyle.Light;
                lbAuthor.Theme = MetroThemeStyle.Light;
                lbSlow.Theme = MetroThemeStyle.Light;
                lbFast.Theme = MetroThemeStyle.Light;
                trkbarAnimationSpeed.Theme = MetroThemeStyle.Light;
                toggleDarkTheme.Theme = MetroThemeStyle.Light;
                Theme = MetroThemeStyle.Light;
            }
            Refresh();
        }
    }
}
