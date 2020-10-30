using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words_in_a_Text_File__Part_1__Open_File_Dialog_Box20201030
{
    class WordCounter
    {
        public string word { get; set; }

        public int frequency { get; set; }

        public WordCounter(string word, int frequency)
        {
            this.word = word;
            this.frequency = frequency;
        }
    }
}
