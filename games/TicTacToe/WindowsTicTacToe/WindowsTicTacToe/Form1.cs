using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTicTacToe
{
    public partial class TicTacToeForm : Form
    {
        // Whose turn is it?
        // true = X turn; false = O turn
        Boolean turn = true;

        // the counter for turns; turns > 9 must be a draw
        int turn_count;

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // a  box will pop up when the user clicks on the about section of the help menu
            MessageBox.Show("Developer: James Patterson,\nSoftware: Visual Studio 2018\nDetails: C# Windows Form Application\n", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // the application will exit the execution
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Create the button variable from the object being sent to Button_Click
            Button b = (Button)sender;

            // turn is true; the text will be set as X
            if(turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            // reverse turn
            turn = !turn;

            // ensure the button cannot be clicked again
            b.Enabled = false;

            // increment the turn count
            turn_count++;

            // check for a winner each time a player makes a move
            checkForWinner();

        }// END of Button_Click



        // This will check for a winner 
        private void checkForWinner()
        {
            // this will remain false until we have a winner
            bool winner = false;

            // horizontal wins
            // A1 = A2 = A3      B1 = B2 = B3        C1 = C2 = C3
            // A2 or B1 or C1 have to been disabled too
            if( ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) ||((B1.Text == B2.Text)&&(B2.Text == B3.Text) && (!B1.Enabled)) ||((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)))
            {
                winner = true;
            }

            // Vertical wins
            // A1 = B1 = C1     A2 = B2 = C2        A3 = B3 = C3
            // A1 or A2 or A3 have to been disabled too
            if (((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) || ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) || ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)))
            {
                winner = true;
            }

            // Diagonal wins
            // A1 = B2 = C3     A3 = B2 = C1
            // A1 or A2 or A3 have to been disabled too
            if (((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) || ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled)))
            {
                winner = true;
            }

            if (winner)
            {
                disableButtons();

                String winnerStr = "";

                // this will be executed after a player has made a turn, and the control is about
                // to be shifted to a following player. We will be checking for a winner. Which is 
                // why you might look at this code and wonder why the turn would be true and the winner
                // be O, since turn = true = X and turn = false = O
                if(turn)
                {
                    winnerStr = "PLayer 2 Wins!";
                }
                else
                {
                    winnerStr = "Player 1 Wins!";
                }

                // this will display once a winner has been chosen 
                MessageBox.Show(winnerStr, "The Results Are In...");
            }
            else
            {
                // DRAW
                // if the turn count reaches 9, and there isn't a winner yet
                // the game must be labeled as a draw
                if(turn_count == 9)
                {
                    MessageBox.Show("Bummer, it is a draw.", "The Results Are In...");
                }
            }

        } // END of checkForWinner()

        private void disableButtons()
        {
            // loop through the controls on the form
            foreach(Control c in Controls)
            {
                // this will catch a few items that aren't buttons, but the try/catch block
                // should catch them and ignore the error without any worries
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch
                {
                    // Just Ignore
                }
            }

        } // END of disableButtons()

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset turn to true; X
            turn = true;

            // reset turn count
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    // we are resetting all the buttons back to the enabled position
                    Button b = (Button)c;
                    b.Enabled = true;

                    // we need to reset the button text back to NULL
                    b.Text = "";
                }
                catch
                {
                    // Just Ignore
                }
            }

        }
    }
}
