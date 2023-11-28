using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public int Round = 1; // 1 or 2
        public int tl = 0; public int tm = 0; public int tr = 0; //top-left, top-mid, top-right
        public int ml = 0; public int mm = 0; public int mr = 0; //mid-left, mid-mid, mid-right
        public int bl = 0; public int bm = 0; public int br = 0; //bottom-left, bottom-mid, bottom-right
        public int Stepcount = 0;
        public void wincheck()
        {

            //1 check
            if (tl == 1 && tm == 1 && tr == 1)
            {
                MessageBox.Show("Winner: O","Congrat!");
                Reset();
            }else if (ml == 1 && mm == 1 && mr == 1)
            {
                MessageBox.Show("Winner: O", "Congrat!");
                Reset();
            }
            else if (bl == 1 && bm == 1 && br == 1)
            {
                MessageBox.Show("Winner: O", "Congrat!");
                Reset();
            }
            else if (tl == 1 && ml == 1 && bl == 1)
            {
                MessageBox.Show("Winner: O", "Congrat!");
                Reset();
            }
            else if (tm == 1 && mm == 1 && bm == 1)
            {
                MessageBox.Show("Winner: O", "Congrat!");
                Reset();
            }
            else if (tr == 1 && mr == 1 && br == 1)
            {
                MessageBox.Show("Winner: O", "Congrat!");
                Reset();
            }
            else if (tl == 1 && mm == 1 && br == 1)
            {
                MessageBox.Show("Winner: O", "Congrat!");
                Reset();
            }
            else if (tr == 1 && mm == 1 && bl == 1)
            {
                MessageBox.Show("Winner: O", "Congrat!");
                Reset();
            }

            //2 check
            if (tl == 2 && tm == 2 && tr == 2)
            {
                MessageBox.Show("Winner: X", "Congrat!");
                Reset();
            }
            else if (ml == 2 && mm == 2 && mr == 2)
            {
                MessageBox.Show("Winner: X", "Congrat!");
                Reset();
            }
            else if (bl == 2 && bm == 2 && br == 2)
            {
                MessageBox.Show("Winner: X", "Congrat!");
                Reset();
            }
            else if (tl == 2 && ml == 2 && bl == 2)
            {
                MessageBox.Show("Winner: X", "Congrat!");
                Reset();
            }
            else if (tm == 2 && mm == 2 && bm == 2)
            {
                MessageBox.Show("Winner: X", "Congrat!");
                Reset();
            }
            else if (tr == 2 && mr == 2 && br == 2)
            {
                MessageBox.Show("Winner: X", "Congrat!");
                Reset();
            }
            else if (tl == 2 && mm == 2 && br == 2)
            {
                MessageBox.Show("Winner: X", "Congrat!");
                Reset();
            }
            else if (tr == 2 && mm == 2 && bl == 2)
            {
                MessageBox.Show("Winner: X", "Congrat!");
                Reset();
            }
            //withdraw
            if(Stepcount == 9)
            {
                MessageBox.Show("Sadly no winner :( ", "Sadge!");
                Reset();
            }
        }
        public void Roundcheck()
        {
            if(Round == 1)
            {
                button10.Text = "O";
            }
            else
            {
                button10.Text = "X";
            }
        }
        public void Reset()
        {
            Stepcount = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            tl = 0;tm = 0;tr = 0;
            ml = 0;mm = 0;mr = 0;
            bl = 0;bm = 0;br = 0;
            Round = 1;
            Roundcheck();
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // O = 1
            // X = 2
            Reset();
            button10.Enabled = false;
            Roundcheck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Round == 1)
            {
                button1.Text = "O";
                tl = 1;
                Round = 2;
            }
            else
            {
                button1.Text = "X";
                tl = 2;
                Round = 1;
            }
            button1.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Round == 1)
            {
                button2.Text = "O";
                tm = 1;
                Round = 2;
            }
            else
            {
                button2.Text = "X";
                tm = 2;
                Round = 1;
            }
            button2.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Round == 1)
            {
                button3.Text = "O";
                tr = 1;
                Round = 2;
            }
            else
            {
                button3.Text = "X";
                tr = 2;
                Round = 1;
            }
            button3.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Round == 1)
            {
                button4.Text = "O";
                ml = 1;
                Round = 2;
            }
            else
            {
                button4.Text = "X";
                ml = 2;
                Round = 1;
            }
            button4.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Round == 1)
            {
                button5.Text = "O";
                mm = 1;
                Round = 2;
            }
            else
            {
                button5.Text = "X";
                mm = 2;
                Round = 1;
            }
            button5.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Round == 1)
            {
                button6.Text = "O";
                mr = 1;
                Round = 2;
            }
            else
            {
                button6.Text = "X";
                mr = 2;
                Round = 1;
            }
            button6.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Round == 1)
            {
                button7.Text = "O";
                bl = 1;
                Round = 2;
            }
            else
            {
                button7.Text = "X";
                bl = 2;
                Round = 1;
            }
            button7.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Round == 1)
            {
                button8.Text = "O";
                bm = 1;
                Round = 2;
            }
            else
            {
                button8.Text = "X";
                bm = 2;
                Round = 1;
            }
            button8.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Round == 1)
            {
                button9.Text = "O";
                br = 1;
                Round = 2;
            }
            else
            {
                button9.Text = "X";
                br = 2;
                Round = 1;
            }
            button9.Enabled = false;
            Stepcount++;
            Roundcheck();
            wincheck();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
//lul
