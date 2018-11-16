using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_week_1_deel_2
{
    class MultiChoiceQuestion : Question
    {
        public List<String> ChoiceQuestion = new List<String>();

        public void AddChoice(string choice, Boolean correct)
        {
            ChoiceQuestion.Add(choice);
            if (correct)
            {
                Answer = choice;
            }
        }

        public override void Display()
        {
            base.Display();
            foreach (string choice in ChoiceQuestion)
            {
                Console.WriteLine(choice);
            }
        }
    }
}

