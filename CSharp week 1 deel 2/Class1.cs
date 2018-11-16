using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_week_1_deel_2
{
   public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }
        public string Categorie { get; set; }
        public int Moeilijkheidsgraad { get; set; }

        public Question()
        {
            
        }

        public void testen() { }

        public Boolean CheckAnswer(String response)
        {
            return response.Equals(Answer);
        }

        public virtual void Display()
        {
            Console.WriteLine(Text);
        }
    }
}

