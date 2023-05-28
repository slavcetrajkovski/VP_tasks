using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public RandomPicker RandomPicker { get; set; }
        public HangmanWord hangmanWord { get; set; }
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
            RandomPicker = new RandomPicker();
            this.init();
        }

        private void init()
        {
            hangmanWord = new HangmanWord(RandomPicker.pick());
            tbTimer.Text = "02:00";
            updateTextBoxes();
            pbTries.Maximum = HangmanWord.MAX_RETRIES;
            pbTries.Value = 0;
            timeLeft = 120;
            timer1.Start();
            pbTimer.Maximum = 120;
            pbTimer.Value = 120;
            tbLetter.Text = " ";
        }

        private void updateTextBoxes()
        {
            tbWordState.Text = hangmanWord.GetMaskedWord();
            tbGuessedLetter.Text = hangmanWord.GetMaskedGuessedLetters();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbLetter.Text))
            {
                char letter = tbLetter.Text[0];
                hangmanWord.GuessLetter(letter);
                updateTextBoxes();
                pbTries.Value = hangmanWord.WrongCount;
                if (hangmanWord.Win())
                {
                    timer1.Stop();
                    ShowMessageBoxForGame("Честитки, победивте! Дали сакате нова игра?");
                }else if (hangmanWord.Lose())
                {
                    timer1.Stop();
                    ShowMessageBoxForGame("Кој сака нека честита, изгубивте! Дали сакате нова игра?");
                }

            }
        }

        private void ShowMessageBoxForGame(string desc)
        {
            DialogResult dr = MessageBox.Show(desc, "Game Over", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.init();
            }
            else
            {
                this.Close();
            }
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            tbTimer.Text = String.Format("{0}:{1}", timeLeft / 60, timeLeft % 60);
            pbTimer.Value = timeLeft;
            if(timeLeft < 0)
            {
                ShowMessageBoxForGame("Времет заврши! Дали сакате нова игра?");
            }
        }
    }
}
