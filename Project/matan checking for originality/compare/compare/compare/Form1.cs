using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace compare
{
    public partial class Form1 : Form
    {
        public WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "Redbone.mp3";
           // player.controls.stop();
            
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Form2 form2 = new Form2();  
            Compares compares = new Compares();
            compares.compares("E:\\DRIVE\\OneDrive - Kinneret Academic College\\C#JAVATesting\\java Hw\\java Hw");
            form2.match = compares.match;
            this.Hide();
            form2.Show();
        }
    }
}
