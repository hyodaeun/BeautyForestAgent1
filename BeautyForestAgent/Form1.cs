using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void VisibleChange(bool visible)
        {
            this.Visible = visible;
            this.btnTray.Visible = !visible;
        }
        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void BtnTray_Click_1(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true);

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnTray.Visible = false;
            Application.ExitThread();
        }

       
    }
}
