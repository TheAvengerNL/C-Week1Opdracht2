using System;

namespace Quiz
{
    class Quiz
    {
        static void Main(string[] args)
        {
            Question open = new Question {Text = "Who was the inventor of Java?", Answer = "James Gosling"};
            open.Display();
            Console.Write("response: "); String response = Console.ReadLine();
            Console.WriteLine(open.CheckAnswer(response)); Console.ReadLine();
        }
    }

    class Question
    {
        public String Text { get; set; }
        public String Answer { get; set; }

        public Boolean CheckAnswer(String response)
        {
            return response.ToLower().Equals(Answer.ToLower());
        }

        public void Display()
        {
            Console.WriteLine(Text);
        }
    }

    class MultipleChoice : Question
    {

    }
}
