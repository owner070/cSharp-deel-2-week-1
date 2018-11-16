using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_week_1_deel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question()
            {
                Text = "Who was the inventor of Java?",
                Answer = "James Gosling",
                Categorie = "OpenVragen",
                Moeilijkheidsgraad = 2
            };

            Question q2 = new Question()
            {
                Text = "President van Rusland",
                Answer = "Putin",
                Categorie = "OpenVragen",
                Moeilijkheidsgraad = 3
            };

            Question q3 = new Question()
            {
                Text = "President van Amerika",
                Answer = "Donald Trump",
                Categorie = "OpenVragen",
                Moeilijkheidsgraad = 2
            };

            Question q4 = new Question()
            {
                Text = "1+1",
                Answer = "2",
                Categorie = "OpenVragen",
                Moeilijkheidsgraad = 1
            };

            MultiChoiceQuestion MQ1 = new MultiChoiceQuestion()
            {
                Text = "Wie is Putin",
                Categorie = "Java",
                Moeilijkheidsgraad = 2
            };

            MQ1.AddChoice("President van Australia", false);
            MQ1.AddChoice("President van Amerika", false);
            MQ1.AddChoice("President van Nederland", false);
            MQ1.AddChoice("President van Rusland", true);

            MultiChoiceQuestion MQ2 = new MultiChoiceQuestion()
            {
                Text = "Wie is Donald Trump",
                Categorie = "Java",
                Moeilijkheidsgraad = 2
            };

            MQ2.AddChoice("President van Australia", false);
            MQ2.AddChoice("President van Amerika", false);
            MQ2.AddChoice("President van Nederland", false);
            MQ2.AddChoice("President van Rusland", true);

            List<Question> openVragen = new List<Question>() { q3, q2, q4, q1 };
            List<Question> multiChoiceQuestion = new List<Question>() { MQ2, MQ1 };

            List<Question> openvraag = openVragen.OrderBy(s => s.Moeilijkheidsgraad).ToList();
            List<Question> meerkeuze = multiChoiceQuestion.OrderBy(s => s.Moeilijkheidsgraad).ToList();


            Console.WriteLine(" Kies een moeilijkheidsgraad 1,2,3 of kies een categorie openvragen/meerkeuzevragen");
            String antwoord = Console.ReadLine();

            switch (antwoord)
            {
                case "1":
                    foreach (Question question in openVragen){
                        if (question.Moeilijkheidsgraad == 1){
                            PresentQuestion(question);}}

                     foreach (Question question in multiChoiceQuestion){
                        if (question.Moeilijkheidsgraad == 1){
                            PresentQuestion(question);}}
                    break;
                case "2":
                    foreach (Question question in openVragen){
                        if (question.Moeilijkheidsgraad == 2){
                            PresentQuestion(question);}}

                     foreach (Question question in multiChoiceQuestion){
                        if (question.Moeilijkheidsgraad == 2){
                            PresentQuestion(question);}}
                    break;
                case "3":
                    foreach (Question question in openVragen){
                        if (question.Moeilijkheidsgraad == 3){
                            PresentQuestion(question);}}

                    foreach (Question question in multiChoiceQuestion){
                        if (question.Moeilijkheidsgraad == 3){
                            PresentQuestion(question);}}
                    break;
                    break;
                case "openvragen":
                    foreach (Question question in openVragen){
                        PresentQuestion(question);}
                    break;
                case "meerkeuzevragen":
                    foreach (Question question in multiChoiceQuestion){
                        PresentQuestion(question);}
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.ReadKey();
        }

        public static void PresentQuestion(Question q)
        {
            Console.WriteLine(" ");
            q.Display();
            Console.WriteLine("Your answer: ");
            String response = Console.ReadLine();
            Console.WriteLine(q.CheckAnswer(response));
        }
    }
}
