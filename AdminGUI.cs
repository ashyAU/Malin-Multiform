using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malin_Multiform
{
    public partial class AdminGUI : Form
    {
        public AdminGUI()
        {
            InitializeComponent();

        }

        private void AdminGUI_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.L)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.W)
                {
                    MessageBox.Show("Test");
                }
                if (e.KeyCode == Keys.A)
                {
                }
            }
        }
    }
}
