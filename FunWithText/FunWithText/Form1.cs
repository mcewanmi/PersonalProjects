using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_Options_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox_Options.SelectedIndex == -1)
            {
                listBox_Options.SelectedIndex = 0;
                MessageBox.Show("You forgot to select an item! Defaulted to \"Reverse String\"");
            }
            String choice = listBox_Options.SelectedItem.ToString();
            if (choice.Equals("Reverse String"))
                Reverse(textBox1.Text);
            else if (choice.Equals("Pig Latin"))
                Latin(textBox1.Text);
            else if (choice.Equals("Count Vowels"))
                CountVowels(textBox1.Text);
            else if (choice.Equals("Check if Palindrome"))
                Palindrome(textBox1.Text);
            else
                Count(textBox1.Text);
        }
        private void Count(String text)
        {
            int x = 1;
            foreach (char c in text)
                if (c == ' ')
                    x++;
            textBox1.Text += "\r\nThis string contains " + x + " words.";
        }
        private void Palindrome(String text)
        {
            String front;
            String back;
            if (text.Length % 2 == 0)
            {
                front = text.Substring(0, text.Length / 2);
                back = text.Substring(text.Length / 2);
            }
            else
            {
                front = text.Substring(0, text.Length / 2);
                back = text.Substring(text.Length / 2+1);
            }
            if (front.Equals(Reversal(back)))
                textBox1.Text += "\r\nThis is a palindrome.";
            else
                textBox1.Text += "\r\nThis is not a palindrome.";
        }

        private String Reversal(String str)
        {
            Char[] reversed = str.ToCharArray();
            char c;
            for (int x = 0; x < reversed.Length / 2; x++)
            {
                c = reversed[x];
                reversed[x] = reversed[reversed.Length - 1 - x];
                reversed[reversed.Length - x - 1] = c;

            }
            String output;
            output = new String(reversed);
            return output;
        }

        private void Reverse(String text)
        {
            
            textBox1.Text = Reversal(text);
        }
        private void Latin(String content)
        {
            int y = 0;
            String output = "";
            String text;

            if (content.Contains(' '))
                y = content.IndexOf(' ');
            else
                y = content.Length;

            while (content.Length > 0)
            {
              
                text = content.Substring(0, y);
                if (y < content.Length)
                    content = content.Substring(y + 1);
                else
                    content = "";
                
                Char.ToLower(text[0]);
                if (text[0].Equals('a') || text[0].Equals('e') || text[0].Equals('i') || text[0].Equals('o') || text[0].Equals('u'))
                {
                    text += "-yay";
                }
                else
                {
                    int x = 0;
                    while (!(text[x].Equals('a') || text[x].Equals('e') || text[x].Equals('i') || text[x].Equals('o') || text[x].Equals('u')) && x < text.Length - 1)
                    {
                        x++;
                    }
                    text = text.Substring(x) + "-" + text.Substring(0, x) + "ay";
                }

                if (output.Length == 0)
                    output = text;
                else
                    output += " " + text;

                if (content.Contains(' '))
                    y = content.IndexOf(' ');
                else
                {
                    y = content.Length;
                    text = content;
                }
                
            }
            textBox1.Text = output;
        }
        private void CountVowels(String text)
        {
            int x = 0;
            for (int y = 0; y < text.Length; y++) { 
               if (text[y].Equals('a') || text[y].Equals('e') || text[y].Equals('i') || text[y].Equals('o') || text[y].Equals('u'))
                    x++;
            }

            textBox1.Text = text +"\r\nNumber of Vowels: " + x;

        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
