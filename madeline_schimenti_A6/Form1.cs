using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madeline_schimenti_A6
{
    public partial class Form1 : Form
    {
        //List<string> words; 

        public static List<string> words;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            words = new List<string>();

            string userInput = textBoxInputSentence.Text;

            words = userInput.ToLower().Split().Distinct().ToList();

            var wordQuery =

                from word in words
                orderby word
                select word;

            textBoxDistinctWords.Clear();
            foreach (string element in words)
                textBoxDistinctWords.AppendText(element.ToString() + "\n");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAllWord_Click(object sender, EventArgs e)
        {

            words = new List<string>();

            string userInput = textBoxInputSentence.Text;

            words = userInput.ToLower().Split().ToList();

            var wordQuery =

                from word in words
                orderby word
                select word;

            textBoxAllWords.Clear();
            foreach (string element in words)
                textBoxAllWords.AppendText(element.ToString() + "\n");

        }

        private void textBoxDistinctWords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
