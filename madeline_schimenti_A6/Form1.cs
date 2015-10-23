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
        List<string> words; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAllWord_Click(object sender, EventArgs e)
        {
            words = new List<string>();

            string userInput = textBoxInputSentence.Text;

            words.Add(userInput);

            string[] wordsInSentence = userInput.Split();

            textBoxAllWords.Clear();
            foreach (string element in wordsInSentence)
               textBoxAllWords.AppendText(element.ToString() + "\n");

            

        }
    }
}
