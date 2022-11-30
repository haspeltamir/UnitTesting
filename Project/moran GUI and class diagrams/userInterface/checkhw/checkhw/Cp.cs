using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkhw
{
    public partial class Cp : Form
    {
        public Cp()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void Cp_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush brush = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            graphics.FillRectangle(brush, area);
            graphics.DrawRectangle(pen, area);
        }
        private void next_check_btn_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sv = new FolderBrowserDialog();
            sv.ShowDialog();
            this.folder_url.Text = sv.SelectedPath;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                stateText.Text = progressBar1.Value.ToString() + "%";
            }
        }

        private void Cp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
