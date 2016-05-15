using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushBlock
{
    public partial class Form1 : Form


    {
        System.Media.SoundPlayer startSound = new System.Media.SoundPlayer(@"C:\Users\Mario\Desktop\80s\referee.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start_levels sl = new Start_levels(); 
            sl.Show(); 
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            btnInstructions.Visible = false;
            btnStart.Visible = false;
            button4.Visible = false;
            button7.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.MinimumSize = new Size(1240, 780);
            this.MaximumSize = new Size(1240, 780);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1240, 780);
            this.MaximumSize = new Size(1240, 780);
            startSound.Play();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            btnInstructions.Visible = true;
            btnStart.Visible = true;
            button4.Visible = true;
            button7.Visible = false;
        }

       
        
    }
}
