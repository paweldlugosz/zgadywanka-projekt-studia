using Obiektowo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zgadywanka_projekt_studia
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(from.Text);
            int end = Convert.ToInt32(to.Text);

            int min = Math.Min(start, end);
            int max = Math.Max(start, end);

            from.Text = min.ToString();
            to.Text = max.ToString();

            game = new Game(min, max, cheat.Checked);
            configGroup.Enabled = false;
            gameGroup.Enabled = true;
            table.Items.Clear();
        }

        private bool validateNumber(string input)
        {
            try
            {
                Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool validateTextBox(TextBox textBox)
        {
            bool correct = validateNumber(textBox.Text);
            textBox.BackColor = correct || textBox.Text == "" ? Color.White : Color.IndianRed;
            return correct;
        }

        private void Range_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox((TextBox)sender);
            newGame.Enabled = validateNumber(from.Text) && validateNumber(to.Text);
        }

        private void Input_KeyUp(object sender, KeyEventArgs e)
        {
            validateTextBox((TextBox)sender);
            bool correct = validateNumber(input.Text);
            check.Enabled = correct;
            if (e.KeyCode == Keys.Enter && correct) add();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            add();
        }

        private void add()
        {
            Step step = game.Rate(Convert.ToInt32(input.Text));
            response.Text = step.response.ToString();

            if (step.response == Game.Response.Equal)
            {
                response.ForeColor = Color.Black;
                MessageBox.Show($"Udało Ci się odgadnąć liczbę. Wynosi ona {input.Text}.", "Gratulacje");
                configGroup.Enabled = true;
                gameGroup.Enabled = false;
            }
            else
            {
                response.ForeColor = Color.IndianRed;
            }

            input.Clear();
            input.Focus();
            check.Enabled = false;

            string[] row = { step.proposition.ToString(), step.response.ToString(), step.time.ToString() };
            ListViewItem listViewItem = new ListViewItem(row);
            table.Items.Add(listViewItem);
            table.Items[table.Items.Count - 1].EnsureVisible();
        }

        private void GiveUp_Click(object sender, EventArgs e)
        {
            int number = game.GiveUp();
            configGroup.Enabled = true;
            gameGroup.Enabled = false;
            MessageBox.Show($"Liczba do zgadnięcia wynosiła {number}.", "Poddałeś się");
        }

    }
}
