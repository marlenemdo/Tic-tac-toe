using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            b.Enabled = false;
            turn_count++;
            turn = !turn;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool theresWinner = false;
            if ((A1.Text==A2.Text) && (A2.Text==A3.Text) && (!A1.Enabled))
            {
                theresWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                theresWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                theresWinner = true;
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                theresWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                theresWinner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                theresWinner = true;
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!B2.Enabled))
            {
                theresWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                theresWinner = true;
            }
            if (theresWinner)
            {                
                String winner = "";
                if (turn)
                {
                    winner = "O";                    
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show(winner + " vinner");
                Reset();



            }
            else
            {
                if(turn_count == 9)
                {
                    MessageBox.Show("Ingen ha vunnit");
                    Reset();
                }
            }
        }
          
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch 
            {                
            }
        }

        private void Reset()
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch
            {
            }
        }

    }
}
