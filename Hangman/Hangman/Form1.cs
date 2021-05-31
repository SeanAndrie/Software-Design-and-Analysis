using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {

        List<Label> labellist = new List<Label>();
        string generatedword = " ";
        int NumberOfLives = 8;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Labels();
            imagebase.Image = images.Images[8];
        }

        public void SubmitLetterButton_Click_1(object sender, EventArgs e)
        {

            char letter = letterInput.Text.ToLower().ToCharArray()[0];
            if (!char.IsLetter(letter))
            {
                MessageBox.Show("YOU MAY ONLY SUBMIT A LETTER\n PLEASE TRY AGAIN...", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (generatedword.Contains(letter))
            {

                char[] letters = generatedword.ToCharArray(); //Converts generated word into character array

                for (int i = 0; i < letters.Length; i++) //Converts each character in the generated word into a string to replace label placeholders. 
                {
                    if (letters[i] == letter)
                    {
                        labellist[i].Text = letter.ToString();
                    }
                }

                foreach (Label lbl in labellist)
                    if (lbl.Text == "_") return;
                MessageBox.Show("YOU WON!\nTHE SECRET WORD WAS: " + generatedword.ToUpper(), "CONGRATULATIONS!");
                DialogResult response = MessageBox.Show("WOULD YOU LIKE TO PLAY AGAIN?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    Reset();
                }

                else
                {
                    Application.Exit();
                }

            }

            else
            {
                NumberOfLives--;
                Lives.Text = "Lives: " + NumberOfLives.ToString();//Lives Label

                if (NumberOfLives == 8)
                {
                    imagebase.Image = images.Images[8];
                }

                else if (NumberOfLives == 7)
                {
                    imagebase.Image = images.Images[7];
                }

                else if (NumberOfLives == 6)
                {
                    imagebase.Image = images.Images[6];
                }

                else if (NumberOfLives == 5)
                {
                    imagebase.Image = images.Images[5];
                }

                else if (NumberOfLives == 4)
                {
                    imagebase.Image = images.Images[4];
                }

                else if (NumberOfLives == 3)
                {
                    imagebase.Image = images.Images[3];
                }

                else if (NumberOfLives == 2)
                {
                    imagebase.Image = images.Images[2];
                }

                else if (NumberOfLives == 1)
                {
                    imagebase.Image = images.Images[1];
                }

                else // Lose Message Box
                {
                    imagebase.Image = images.Images[0];
                    MessageBox.Show("YOU LOST!\nTHE SECRET WORD WAS: " + generatedword.ToUpper());
                    DialogResult response = MessageBox.Show("WOULD YOU LIKE TO PLAY AGAIN?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == DialogResult.Yes)
                    {
                        Reset();
                    }

                    else
                    {
                        Application.Exit();
                    }

                }
            }
        }

        public void Reset()
        {
            WordGenerator();
            Labels();
            NumberOfLives = 8;
            Lives.Text = "Lives: " + NumberOfLives.ToString();//Lives Label
            imagebase.Image = images.Images[8];
        }

        public void GenerateNewWord_Click(object sender, EventArgs e)
        {
            Reset();
            MessageBox.Show("SECRET WORD: " + generatedword.ToUpper());
        }

        public void Labels()
        {
            generatedword = WordGenerator();
            char[] letter = generatedword.ToCharArray();

            int space = 420 / letter.Length; //Space Between Labels

            for (int i = 0; i < letter.Length; i++) //Create labels (*) for generated word
            {
                labellist.Add(new Label());

                labellist[i].Text = "_";
                labellist[i].Font = new Font("Segoe UI", 12);

                labellist[i].Parent = groupBox3;
                labellist[i].Location = new Point((i * space) + 50, 100); //Position on GroupBox3

                labellist[i].CreateControl();
                labellist[i].BringToFront();
            }

            WordLength.Text = "Word Length: " + (letter.Length).ToString();// Word Length Label
            Lives.Text = "Lives: " + NumberOfLives.ToString();//Lives Label
        }

        public string WordGenerator() //Reads a random line from the text file
        {
            var WordGenerator = new Random();

            string filepath = @"D:\Randy\Documents\Hangman Program\WordList.txt";
            string[] lines = File.ReadAllLines(filepath);

            return lines[WordGenerator.Next(0, lines.Length)];
        }

        private void LetterInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void WordLength_Click(object sender, EventArgs e)
        {

        }

        private void lives_Click(object sender, EventArgs e)
        {

        }

        private void imagebase_Click(object sender, EventArgs e)
        {

        }
    }
}
