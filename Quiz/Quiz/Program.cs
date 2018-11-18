﻿using System;
using System.Collections.Generic;

namespace Quiz
{
    class Quiz
    {
        static void Main(string[] args)
        {
            //open vraag 1
            Question open1 = new Question {
                Text = "Who was the inventor of Java?",
                Answer = "James Gosling",
                Moeilijkheidsgraad = "2",
                Categorie = "Technologie"
            };
            
            //open vraag 2
            Question open2 = new Question
            {
                Text = "Waar staat PC voor?",
                Answer = "Personal Computer",
                Moeilijkheidsgraad = "1",
                Categorie = "Technologie"
            };

            //multiplechoice 1
            MultipleChoice multi1 = new MultipleChoice
            {
                Text = "What is geen programeertaal?",
                Moeilijkheidsgraad = "1",
                Categorie = "Technologie"
            };
            multi1.AddChoice("C#", false);
            multi1.AddChoice("Java", false);
            multi1.AddChoice("Scala", false);
            multi1.AddChoice("Ycode", true);

            //present questions
            PresentQuestion(open1);
            PresentQuestion(open2);
            PresentQuestion(multi1);
        }

        public static void PresentQuestion(Question q)
        {
            q.Display();
            Console.Write("response: "); String response = Console.ReadLine();
            Console.WriteLine(q.CheckAnswer(response)); Console.ReadLine();
        }
    }

    class Question
    {
        public String Text { get; set; }
        public String Answer { get; set; }
        public String Moeilijkheidsgraad { get; set; }
        public String Categorie { get; set; }

        public Boolean CheckAnswer(String response)
        {
            return response.ToLower().Equals(Answer.ToLower());
        }

        public virtual void Display()
        {
            Console.WriteLine(Text);
        }
    }

    class MultipleChoice : Question
    {
        private List<String> choices;

        public MultipleChoice()
        {
            choices = new List<string>();
        }

        public void AddChoice(String choice, Boolean correct) 
        {
            choices.Add(choice);
            if (correct)
            {
                String choiceString = choices.Count.ToString();
                Answer = choiceString;
            }
        }
        
        public override void Display()
        {
            base.Display();
            for (int i = 0; i < choices.Count; i++)
            {
                int choiceNumber = i + 1;
                Console.WriteLine(choiceNumber + ": " + choices[i]);
            }
        }
    }

    /*
     * source:
     * https://en.wikipedia.org/wiki/Method_overriding
     */
}
