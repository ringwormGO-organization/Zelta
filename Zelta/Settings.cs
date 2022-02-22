using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelta
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zelta is new ringwormGO web browser with WPF support\n" +
                "GitHub repo:\nhttps://github.com/ringwormGO-organization/Zelta", "About Zelta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings are still in development!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //groupBox1.Visible = true;
        }

        private void btnBackcolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.BackColor = colorDialog1.Color;
            }
        }
    }
}
