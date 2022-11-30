using Microsoft.Win32;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void output_btn_Click(object sender, EventArgs e)
        {
            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            DialogResult result = this.openFileDialog1.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                this.output_url.Text = this.openFileDialog1.FileName;
            }
        }
        private void input_btn_Click(object sender, EventArgs e)
        {
            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            DialogResult result = this.openFileDialog1.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                this.file_url.Text = this.openFileDialog1.FileName;
            }

        }

        private void students_btn_Click(object sender, EventArgs e)
        {
            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            openFileDialog1.Filter = "Zip files(*.zip)|*.zip";
            DialogResult result = this.openFileDialog1.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                this.students_url.Text = this.openFileDialog1.FileName;
            }
        }

        public void next_btn_Click(object sender, EventArgs e)
        {
            var myForm = new Cp();
            myForm.Show();
            this.Hide();

        }

        private void HomePage_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush brush = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            graphics.FillRectangle(brush, area);
            graphics.DrawRectangle(pen, area);
        }

        private void input_btn_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, input_btn.ClientRectangle, SystemColors.ControlLightLight, 0, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 0, ButtonBorderStyle.Outset, SystemColors.ControlLightLight, 0, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 0, ButtonBorderStyle.Outset);
        }
    }
}
