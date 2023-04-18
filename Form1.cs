namespace TicTacToeLast
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int flag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Yigit Edar", "About");
        }

        private void whoStartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Always X Starts!", "Who Starts?");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            flag++;

            checkWinner();
        }

        private void checkWinner()
        {
            bool theWinner = false;
            //yatay kazanma
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                theWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                theWinner = true;

            //dikey kazanma
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                theWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                theWinner = true;

            //Çapraz kazanma
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                theWinner = true;


            if (theWinner)
            {
                endGame();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Kazandý!!", "Tebrikler!!!");
            }//end if
            else
            {
                if (flag == 9)
                    MessageBox.Show("Berabere!", "Beraberlik!");
            }

        }//end checkWinner

        private void endGame()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end foreach
            }//end try
            catch { }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            flag = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end foreach
            }//end try
            catch { }
        }
    }
}