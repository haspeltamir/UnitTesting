using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compare
{
    public partial class Form2 : Form
    {
        public List<string> match = new List<string>();
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer player1 = new WMPLib.WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
            player.URL = "GTA V.mp3";
            player1.URL = "Sound.mp3";
            player.controls.stop();
            player1.controls.stop();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            dataGridView2.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < match.Count; i++)
            {
                dataGridView2.Rows.Add(match.ElementAt(i));
            }

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            player.controls.play();
            player1.controls.play();
            await Task.Delay(7500);
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            player1.controls.stop();
            
            
        }
    }
}

