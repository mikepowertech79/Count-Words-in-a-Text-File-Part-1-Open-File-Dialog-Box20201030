using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Count_Words_in_a_Text_File__Part_1__Open_File_Dialog_Box20201030
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_createWordList_Click(object sender, EventArgs e)
        {
            string allWords = textBox1.Text;
            string[] wordsArray = allWords.Split(' ', ',', '.', '!', '-');

            foreach (string word in wordsArray)
            {

                // only add a word if it is not yet in the list 
                if (!listBox1.Items.Contains(word))
                {
                    listBox1.Items.Add(word);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sortWords_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void btn_countWords_Click(object sender, EventArgs e)
        {
            string allWords = textBox1.Text;
            string[] wordsArray = allWords.Split(' ', ',', '.', '!', '-');

            // change the array into a list. A list has more features than an array.
            // The list can use the find command to see if the word is already in the list

            List<WordCounter> wordCounters = new List<WordCounter>();

            // go through thre word array. If  the word is found in the list, add 1 to the frequency 
            // if the word is not found in the list. Add it to the list and its frequency to 1.

            foreach (string w  in wordsArray)
            {

              WordCounter foundWord =   wordCounters.Find(x => x.word == w);
              if (foundWord == null)
              {
                  // the word is not in the list yet . Add it.
                  wordCounters.Add(new WordCounter(w,1));


              }
              else
              {
                    // the word if found in the list 
                    foundWord.frequency++;

              }

            }
            //   We are done with the loop. The list wordCounters should now have a list of all counted words.
            listView1.Columns.Add("Frequency", 70);
            listView1.Columns.Add("Word", 100);
            
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Descending;



            foreach (WordCounter word in wordCounters)
            {
                String[] rowItem = new string[] { word.frequency.ToString("D5"), word.word  };
                listView1.Items.Add(new ListViewItem(rowItem));

            }

            //OK


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
