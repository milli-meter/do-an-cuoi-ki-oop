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

        private void btRandomData_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Chưa có code", "Sort Visualization", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Chưa có code", "Sort Visualization", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
