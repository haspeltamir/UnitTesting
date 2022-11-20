using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace checkhw
{
    public partial class Cp : Form
    {
        public Cp()
        {
            InitializeComponent();
        }

        private void next_check_btn_Click(object sender, EventArgs e)
        {
            stateText.Text = "Start Checking";
            progressBar1.Visible = true;
            progressBar1.Minimum = 1; 
            progressBar1.Maximum = 10000;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            for(int i = 0; i < progressBar1.Maximum; i++) 
            {
                progressBar1.PerformStep();
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                stateText.Text = "Finished";
            }
            else
            {
               stateText.Text = "Start Checking";
            }
    
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sv = new FolderBrowserDialog();   
            sv.ShowDialog();
        }
    }
}
